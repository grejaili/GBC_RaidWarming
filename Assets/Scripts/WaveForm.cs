using UnityEngine;
using System.Collections;

public class WaveForm : MonoBehaviour {

	public bool destroyedByPlayer;
	public float lifeTime = 2.0f;
	public float waveSpeed = 1.0f;
	public float waveRange = 1.0f;
	public float killCheckInterval = 0.5f;
	public ParticleSystem waveParticles;

	float timer = 0.0f;
	float waveSize = 0.0f;
	float timeAlive = 0.0f;
	ElementalType.Element elementalType;

	void Start ()
	{
		ParticleSystem.MainModule temp = waveParticles.main;
		temp.startSpeed = waveSpeed * lifeTime;
		
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
						if (c.gameObject.GetComponentInParent<EnemyMovement>().GetType() == this.elementalType)
						{
							c.GetComponentInParent<EnemyMovement>().Explode(true);
						}
					}
				}
				timer = 0.0f;
			}
		}
		

		// Handle Lifespan
		timeAlive += Time.deltaTime;
		if (timeAlive >= lifeTime)
		{
			//Debug.Log("/// timed out");
			//gameObject.SetActive(false);
			Destroy(gameObject);
		}

		if (waveSize >= waveRange - 0.5f)
		{
			//Debug.Log("/// wave ranged out");
			//gameObject.SetActive(false);
			Destroy(gameObject);
		}
	}

	public void SetElement(ElementalType.Element newType)
	{
		elementalType = newType;
		//Debug.Log(gameObject.name + " element type: " + type.ToString());
	}
}
