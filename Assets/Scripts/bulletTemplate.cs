using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTemplate : MonoBehaviour 
{
    float speed = 50f;
    Vector3 travelDirection;

	[SerializeField]
	public ElementalType.Element elementType;
	

    //bulletsType m_bulletType;

	// Use this for initialization
    public void StartBullet (Vector3 bulletDirection, float bulletSpeed = 50f) 
    {
		//Debug.Log(elementType.ToString());
        this.speed = bulletSpeed;   	
        this.travelDirection = bulletDirection;

        gameObject.GetComponent<Rigidbody>().velocity = bulletDirection * this.speed;
	}
	
	// Update is called once per frame
	protected void Update () 
    {
        //transform.Translate(travelDirection * this.speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        Debug.Log(collision.gameObject.tag);

        if(collision.gameObject.tag == "test")
        {
            collision.gameObject.SendMessage("Explode", elementType);
        }
    }

   
}
