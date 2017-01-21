using UnityEngine;
using System.Collections;

public class WaveForm : MonoBehaviour {

	public float lifeTime = 2.0f;
	public float waveSpeed = 1.0f;
	public float waveRange = 1.0f;
	public float killCheckInterval = 0.5f;
	public ParticleSystem waveParticles;

	float timer = 0.0f;
	float waveSize = 0.0f;
	float timeAlive = 0.0f;

	void Start ()
	{
		waveParticles.startSpeed = waveSpeed;
		timer = killCheckInterval / 2;
	}
	
	
	void Update ()
	{
		// Wave Propagation
		waveSize = Mathf.Lerp(waveSize, waveRange, Time.deltaTime * waveSpeed);

		// Kill Check
		timer += Time.deltaTime;
		if (timer >= (killCheckInterval / 1))
		{
			Collider[] cols = Physics.OverlapSphere(transform.position, waveSize);
			foreach (Collider c in cols)
			{
				if (c.GetComponentInParent<EnemyMovement>())
				{
					c.gameObject.GetComponentInParent<EnemyMovement>().Explode();
				}
			}
			timer = 0.0f;
		}

		// Handle Lifespan
		timeAlive += Time.deltaTime;
		if (timeAlive >= lifeTime)
			Destroy(gameObject);
	}
}
