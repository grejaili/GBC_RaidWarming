using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class bulletDetails
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 50f;
    public float coolDown    = 0.3f;
    public float bulletDestroyTime = 2f;
}
    
public enum bulletsType
{
    normal,
    fire,
    earth,
    wind,
    water,
}

public class Player : MonoBehaviour 
{
    bool ableToShoot = true;

    [SerializeField]
    LayerMask groundMasks;

    [SerializeField]
    GameObject bulletSpawn;

    [SerializeField]
    bulletsType m_currentBulletType;

    public bulletsType currentBulletType
    {
        get {return m_currentBulletType; }
        set {this.m_currentBulletType = value; }
    }

    [SerializeField]
    bulletDetails[] bulletsType;

	// Use this for initialization
	void Start () {
		
	}

    IEnumerator shootBullet()
    {
        yield return new WaitForSeconds(bulletsType[(int)currentBulletType].coolDown);

        this.ableToShoot = true;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && ableToShoot)
        {
            GameObject bullet = (GameObject)Instantiate(this.bulletsType[(int)currentBulletType].bulletPrefab, 
                                                        bulletSpawn.transform.position, 
                                                        bulletSpawn.transform.rotation);
            
            bullet.GetComponent<bulletTemplate>().StartBullet(transform.forward, 
                                                              this.bulletsType[(int)currentBulletType].bulletSpeed);

            this.ableToShoot = false;

            Destroy(bullet, this.bulletsType[(int)currentBulletType].bulletDestroyTime);

            StartCoroutine(shootBullet());

            Debug.Log("Fire Bullet - "+currentBulletType);
        }
    }
	
	// Update is called once per frame
	void LateUpdate () 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit; 
        if (Physics.Raycast(ray, out hit, 1000f, this.groundMasks))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
	}
}
