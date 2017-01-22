using UnityEngine;
using System.Collections;

public class WaveForm : MonoBehaviour {

	public bool destroyedByPlayer;
	public float lifeTime = 2.0f;
	public float waveSpeed = 1.0f;
	public float waveRange = 1.0f;
	public float killCheckInterval = 0.5f;
	GameObject waveParticles;
	static GameObject[] particleArray = new GameObject[4];

	float timer = 0.0f;
	float waveSize = 0.0f;
	float timeAlive = 0.0f;
	ElementalType.Element elementalType;

	void Awake()
	{
		if (particleArray[3] == null)
		{
			//Debug.Log("we are in the beam");
			for (int i = 0; i < particleArray.Length; i++)
			{
				particleArray[i] = Resources.Load(("Prefabs/" + ((ElementalType.Element)i).ToString() + "WaveParticles")) as GameObject;
			}

		}
	}

	void Start ()
	{
		
		//waveParticles.main = temp;
		//Debug.Log(waveParticles.main.startSpeed.ToString());

		timer = killCheckInterval / 2;
	}
	
	
	void Update ()
	{
		// Wave Propagation
		waveSize = Mathf.Lerp(waveSize, waveRange, Time.deltaTime * (waveSpeed / 2));
		//Debug.DrawRay(transform.position, Vector3.forward * waveSize, Color.white);
		//Debug.DrawRay(transform.position, Vector3.right * waveSize, Color.white);
		//Debug.DrawRay(transform.position, -Vector3.forward * waveSize, Color.white);
		//Debug.DrawRay(transform.position, -Vector3.right * waveSize, Color.white);

		if (destroyedByPlayer)
		{
			// Kill Check
			timer += Time.deltaTime;
			if (timer >= (killCheckInterval / 1))
			{
				Collider[] cols = Physics.OverlapSphere(transform.position, waveSize);
				foreach (Collider c in cols)
				{
					if (c.GetComponentInParent<EnemyMovement>())
					{
						if (c.gameObject.GetComponentInParent<EnemyMovement>().GetType() == elementalType)
						{
							c.GetComponentInParent<EnemyMovement>().Explode(true);
						}
					}
				}
				timer = 0.0f;
			}
		}
		

		// Lifespan / Destroy
		timeAlive += Time.deltaTime;
		if (timeAlive >= lifeTime)
		{
			Destroy(gameObject);
		}

		if (waveSize >= waveRange - 0.5f)
		{
			Destroy(gameObject);
		}
	}

	void SpawnParticleSystem()
	{
		//Debug.Log(elementalType.ToString());
		if (!waveParticles)
		{
			waveParticles = Instantiate(particleArray[(int)elementalType],
									gameObject.transform.position,
									Quaternion.Euler(-90, 0, 0),
									this.transform);
		}
		
	}

	public void SetElement(ElementalType.Element newType)
	{
		elementalType = newType;
		SpawnParticleSystem();
		//Debug.Log(gameObject.name + " element type: " + type.ToString());
	}
}
