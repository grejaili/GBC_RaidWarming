using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	//public enum EnemyType { Fire, Air, Earth, Water };
	
	public Transform target;
	public float moveSpeed;
	public float turnSpeed;
	public float maxHealth;
	public float waveRadius;
	public GameObject Wave;
	Rigidbody rb;
	float health;
    [SerializeField]
	ElementalType.Element element;
	//EnemyType type;

	void OnEnable()
	{
		
	}

	void Start ()
	{
		

		if (!target)
			target = GameObject.FindGameObjectWithTag("Player").transform;

		rb = GetComponent<Rigidbody>();
		health = maxHealth;

		int rando = Random.Range(0, 3);
		switch (rando)
		{
			case 0:
				element = ElementalType.Element.Fire;
				GetComponentInChildren<MeshRenderer>().material.color = Color.red;
				break;

			case 1:
				element = ElementalType.Element.Air;
				GetComponentInChildren<MeshRenderer>().material.color = Color.white;
				break;

			case 2:
				element = ElementalType.Element.Earth;
				GetComponentInChildren<MeshRenderer>().material.color = Color.gray;
				break;

			case 3:
				element = ElementalType.Element.Water;
				GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
				break;
		}

		//Debug.Log(element.ToString());
	}
	
	
	void Update ()
	{
		ChasePlayer();
	}


	void ChasePlayer()
	{
		// Rotate to Target
		var dir = target.position - transform.position;
		Quaternion rotToTarget = Quaternion.LookRotation(dir);
		transform.rotation = Quaternion.Lerp(transform.rotation, 
											 rotToTarget,
											 Time.deltaTime * turnSpeed);

		// Forward Propulsion
		rb.velocity = transform.forward * moveSpeed;
	}


	void OnCollisionEnter(Collision c)
	{
		switch(c.gameObject.tag)
		{
			case "Player":	Explode(); break;
			case "Wave":	Explode(); break;
            case "Bullet":  checkType(c.gameObject); break;
		}
	}


	public void Explode()
	{
		GameObject newWave = (GameObject)Instantiate(Wave, 
								transform.position + Vector3.up * (transform.localScale.y / 2),
								Quaternion.identity);
		if (newWave)
		{
			Destroy(gameObject);
		}
	}

    public void checkType(GameObject c)
    {
        Debug.Log(this.gameObject.name + "hit by a " + c.gameObject.GetComponent<bulletTemplate>().elementType.ToString() + " element type");
        Debug.Log(this.gameObject.name + " element type: " + this.element.ToString());
		if (ElementalType.GetCounterElement(this.element) == c.gameObject.GetComponent<bulletTemplate>().elementType)
		{
            Debug.Log("hueuhehu");
            Explode();
        }
    }
}
