using UnityEngine;
using System.Collections;

public class EnemyMovement : characterTemplate {

	//public enum EnemyType { Fire, Air, Earth, Water };
	
	public Transform target;
	public float moveSpeed;
	public float turnSpeed;
	public float waveRadius;
	Rigidbody rb;
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
			case "Player":
				Explode(false);
				UI_Manager.ResetComboPoints();
				break;
			case "Wave":
				Explode(true);
				break;
            case "Bullet":
				checkType(c.gameObject);
				break;
		}
	}

	void OnDisable()
	{
		
	}

	public void Explode(bool destroyedByPlayer)
	{
		GameObject newWave = (GameObject)Instantiate(Wave, 
								transform.position + Vector3.up * (transform.localScale.y / 2),
								Quaternion.identity);
		if (newWave)
		{
			newWave.GetComponent<WaveForm>().destroyedByPlayer = destroyedByPlayer;

			//Debug.Log(this.gameObject.name + " element: " + this.element.ToString());
			if(destroyedByPlayer)
			{
				UI_Manager.UpdateComboPoints();
				newWave.GetComponent<WaveForm>().SetElement(this.element);
			}
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
            Explode(true);
        }
    }

	public new ElementalType.Element GetType()
	{
		return element;
	}


}
