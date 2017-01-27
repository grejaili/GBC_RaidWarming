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
    public void StartBullet (Vector3 bulletDirection, float bulletSpeed) 
    {
		//Debug.Log(elementType.ToString());
        speed = bulletSpeed;
        travelDirection = bulletDirection;
		ChangeColor();

        gameObject.GetComponent<Rigidbody>().velocity = bulletDirection * speed;
	}

	void ChangeColor()
	{
		if(elementType == ElementalType.Element.Fire)
		{
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
		}
		if (elementType == ElementalType.Element.Air)
		{
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
		}
		if (elementType == ElementalType.Element.Earth)
		{
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
		}
		if (elementType == ElementalType.Element.Water)
		{
			this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
		}
	}
	
	// Update is called once per frame
	protected void Update () 
    {
        //transform.Translate(travelDirection * this.speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.tag == "test")
		{
			collision.gameObject.SendMessage("Explode", elementType);
		}

		//Debug.Log(collision.gameObject.tag);
		Destroy(gameObject);
    }

   
}
