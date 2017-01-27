using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	public float maxDistFromOrigin = 73;
	public float forceBounce = 5;
	Vector3 origin = Vector3.zero;

	// Gun Sound
	AudioSource audioComp;

	float forward;
	float lateral;

	public int elementAura = 0;
	public Sprite fireAura;
	public Sprite earthAura;
	public Sprite airAura;
	public Sprite waterAura;
	SpriteRenderer auraRender;

	// Use this for initialization
	void Start ()
	{
		origin = Vector3.zero;
		rb = GetComponent<Rigidbody>();
		audioComp = GetComponent<AudioSource>();
		auraRender = GameObject.Find("Aura").GetComponent<SpriteRenderer>();
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

		// Shooting
        if (Input.GetButton("Fire1") && ableToShoot)
        {
			audioComp.Play();

			GameObject bullet = (GameObject)Instantiate(bulletsType[(int)currentBulletType].bulletPrefab,  bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			bullet.GetComponent<bulletTemplate>().StartBullet(transform.forward, 70f); //bulletsType[(int)currentBulletType].bulletSpeed);

            ableToShoot = false;

            Destroy(bullet, bulletsType[(int)currentBulletType].bulletDestroyTime);

            StartCoroutine(shootBullet());
        }

		// Handle Aura - ultra ghetto
		int elemento = (int)currentBulletType;
		switch (elemento)
		{
			case 0: auraRender.sprite = fireAura; break;
			case 1: auraRender.sprite = earthAura; break;
			case 2: auraRender.sprite = airAura; break;
			case 3: auraRender.sprite = waterAura; break;
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
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }

		// Moving
		PlayerPilot();
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			UI_Manager.instance.initializedScene = false;
			Destroy(this.gameObject);
		}
	}


	void PlayerPilot()
	{
		float distToOrigin = Vector3.Distance(transform.position, origin);
		//Debug.Log("dist: " + distToOrigin);

		// Move Controls
		forward = Input.GetAxis("Vertical");
		lateral = Input.GetAxis("Horizontal");
		Vector3 forwardVector = Vector3.forward * moveSpeed * forward;
		Vector3 lateralVector = Vector3.right * moveSpeed * lateral;
		rb.velocity = forwardVector + lateralVector;

		// Edge Bounce
		if (distToOrigin >= maxDistFromOrigin)
		{
			Vector3 toOrigin = origin - transform.position;
			rb.AddForce(toOrigin * forceBounce, ForceMode.Force);
		}
	}

	public float GetForwardInput()
	{
		return forward;
	}

	public float GetLateralInput()
	{
		return lateral;
	}
}
