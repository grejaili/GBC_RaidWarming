using UnityEngine;
using System.Collections;

public class EnemyMovement : characterTemplate {

	//public enum EnemyType { Fire, Air, Earth, Water };
	public Transform target;
	public float speedGrowth = 1.1f;
	public float predictiveScalar = 2;
    [SerializeField]
	ElementalType.Element element;
	//EnemyType type;
	Vector3 goalPosition;
	float timeAlive;
	float moveSpeedActual;
	float turnSpeedActual;

	void OnEnable()
	{
		//int rando = Random.Range(0, 4);
		//switch (rando)
		//{
		//	case 0:
		//		element = ElementalType.Element.Fire;
		//		GetComponentInChildren<MeshRenderer>().material.color = Color.red;
		//		break;

		//	case 1:
		//		element = ElementalType.Element.Air;
		//		GetComponentInChildren<MeshRenderer>().material.color = Color.white;
		//		break;

		//	case 2:
		//		element = ElementalType.Element.Earth;
		//		GetComponentInChildren<MeshRenderer>().material.color = Color.black;
		//		break;

		//	case 3:
		//		element = ElementalType.Element.Water;
		//		GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
		//		break;
		//}

		rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
		moveSpeedActual = moveSpeed;
		turnSpeedActual = turnSpeed;
	}

	void Start ()
	{
		if (!target)
			target = GameObject.FindGameObjectWithTag("Player").transform;

		rb = GetComponent<Rigidbody>();
		moveSpeedActual = moveSpeed;
		turnSpeedActual = turnSpeed;
		//Debug.Log(element.ToString());
	}
	
	
	void Update ()
	{
		// Increase Speed and Turn
		timeAlive += Time.deltaTime;
		moveSpeedActual += Time.deltaTime * speedGrowth;
		turnSpeedActual += Time.deltaTime * speedGrowth;
		//Debug.Log(moveSpeedActual);

		// Track player, predict movement
		goalPosition = target.GetComponent<Player>().GetPlayerFuturePos(predictiveScalar);
		ChasePlayer();
	}


	void ChasePlayer()
	{
		// Rotate to Target
		var dir = goalPosition - transform.position;
		Quaternion rotToTarget = Quaternion.LookRotation(dir);
		transform.rotation = Quaternion.Lerp(transform.rotation, 
											 rotToTarget,
											 Time.deltaTime * turnSpeed);

		// Forward Propulsion
		rb.velocity = transform.forward * moveSpeedActual;
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
		GameObject newWave = Instantiate(Wave, 
										transform.position + Vector3.up * (transform.localScale.y / 2),
										Quaternion.identity);
		if (newWave)
		{
			newWave.GetComponent<WaveForm>().destroyedByPlayer = destroyedByPlayer;

			//Debug.Log(this.gameObject.name + " element: " + this.element.ToString());
			if(destroyedByPlayer)
			{
				UI_Manager.UpdateComboPoints();
			}
			newWave.GetComponent<WaveForm>().SetElement(element);
			gameObject.SetActive(false);
		}
	}

    public void checkType(GameObject c)
    {
        //Debug.Log(this.gameObject.name + "hit by a " + c.gameObject.GetComponent<bulletTemplate>().elementType.ToString() + " element type");
        //Debug.Log(this.gameObject.name + " element type: " + this.element.ToString());
		if (element == c.gameObject.GetComponent<bulletTemplate>().elementType)
		{
            //Debug.Log("hueuhehu");
            Explode(true);
        }
    }

	public new ElementalType.Element GetType()
	{
		return element;
	}


}
