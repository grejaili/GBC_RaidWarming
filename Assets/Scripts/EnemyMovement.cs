using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public enum EnemyType { Fire, Air, Earth, Water };
	public Transform target;
	public float moveSpeed;
	public float turnSpeed;
	public float maxHealth;
	public float waveRadius;
	public GameObject Wave;
	Rigidbody rb;
	float health;
    [SerializeField]
    EnemyType type;
	
	void OnEnable()
	{
		int rando = Random.Range(0, 3);
		switch (rando)
		{
			case 0: type = EnemyType.Fire; break;
			case 1: type = EnemyType.Air; break;
			case 2: type = EnemyType.Earth; break;
			case 3: type = EnemyType.Water; break;
		}
	}

	void Start ()
	{
     
		if (!target)
			target = GameObject.FindGameObjectWithTag("Player").transform;

		rb = GetComponent<Rigidbody>();
		health = maxHealth;
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
            case "Bullet":  checkType( c); break;
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

    public void checkType(Collision c)
    {
        Debug.Log(c.gameObject.GetComponent<bulletTemplate>().bulletType.ToString());
        Debug.Log(this.type.ToString());
       if (c.gameObject.GetComponent<bulletTemplate>().bulletType.ToString() == this.type.ToString())
        {
            Debug.Log("hueuhehu");
            Explode();
        }
    }
}
