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
	}
	
	
	void Update ()
	{
		// Increase Speed and Turn
		timeAlive += Time.deltaTime;
		moveSpeedActual += Time.deltaTime * speedGrowth;
		turnSpeedActual += Time.deltaTime * speedGrowth;

		// Track player, predict movement
		if (target)
		{
			goalPosition = target.GetComponent<Player>().GetPlayerFuturePos(predictiveScalar);
			ChasePlayer();
		}
		
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
			//case "Wave":
            case "Bullet":
				checkType(c.gameObject);
				break;
		}
	}


	public void Explode(bool destroyedByPlayer)
	{
		GameObject newWave = Instantiate(Wave, 
										transform.position + Vector3.up * (transform.localScale.y / 2),
										Quaternion.identity);
		if (newWave)
		{
			newWave.GetComponent<WaveForm>().destroyedByPlayer = destroyedByPlayer;
			
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
        if (element == c.gameObject.GetComponent<bulletTemplate>().elementType)
		{
            Explode(true);
        }
    }

	public new ElementalType.Element GetType()
	{
		return element;
	}


}
