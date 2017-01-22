using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class bulletDetails
{
    public GameObject bulletPrefab;
    public float bulletSpeed		= 1000f;
    public float coolDown			= 0.3f;
    public float bulletDestroyTime	= 2f;
}

public enum bulletsType
{
	Fire,
	Earth,
	Air,
	Water
}

public class Player : characterTemplate 
{
    bool ableToShoot = true;

	public Vector3 GetPlayerFuturePos(float scalar)
	{
		return transform.position + rb.velocity * scalar;
	}
	public Vector3 GetPlayerFuturePos()
	{
		return transform.position + rb.velocity;
	}

	[SerializeField]
    LayerMask groundMasks;

    [SerializeField]
    GameObject bulletSpawn;

    [SerializeField]
    bulletsType m_currentBulletType;

	//ElementalType.Element bulletType;

    public bulletsType currentBulletType
    {
        get {return m_currentBulletType; }
        set {this.m_currentBulletType = value; }
    }

    [SerializeField]
    bulletDetails[] bulletsType;

	LineRenderer aimLine;
	Vector3 aimPoint;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
		aimLine = GetComponent<LineRenderer>();
	}

    IEnumerator shootBullet()
    {
        yield return new WaitForSeconds(bulletsType[(int)currentBulletType].coolDown);

        this.ableToShoot = true;
    }

    void Update()
    {
        if (!this.isAlive())
        {
            base.Explode();
            return;
        }

		// Moving
		PlayerPilot();

		// Shooting
        if (Input.GetButton("Fire2") && ableToShoot)
        {
            GameObject bullet = (GameObject)Instantiate(bulletsType[(int)currentBulletType].bulletPrefab,  bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			bullet.GetComponent<bulletTemplate>().StartBullet(transform.forward, 70f); //bulletsType[(int)currentBulletType].bulletSpeed);

            ableToShoot = false;

            Destroy(bullet, bulletsType[(int)currentBulletType].bulletDestroyTime);

            StartCoroutine(shootBullet());
        }
    }
	
	// Update is called once per frame
	void LateUpdate () 
    {
        if (!this.isAlive())
        {
            base.Explode();
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000f, this.groundMasks))
        {
			aimPoint = hit.point;
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }

		aimLine.SetPosition(0, transform.position);
		aimLine.SetPosition(1, aimPoint);
	}

	void PlayerPilot()
	{
		float forward = Input.GetAxis("Vertical");
		float lateral = Input.GetAxis("Horizontal");

		Vector3 forwardVector = Vector3.forward * moveSpeed * forward;
		Vector3 lateralVector = Vector3.right * moveSpeed * lateral;
		rb.velocity = forwardVector + lateralVector;
	}

}
