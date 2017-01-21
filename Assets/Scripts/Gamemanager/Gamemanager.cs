using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gamemanager : MonoBehaviour {

	//public List<GameObject> spawnPatterns = new List<GameObject>();
	//GameObject activePattern;
	public float radius;
	public float spawnRateInSeconds;
	public GameObject[] enemies;
	Vector3 originPoint = Vector3.zero;
	private float timeSinceLastSpawn = 0.0f;
	private float timeOfLastSpawn;


	// Use this for initialization
	void Start ()
	{
		if (radius == 0.0f)
		{
			Debug.Log("Radius not set in inspector, defaulting to 4.0f");
			radius = 4.0f;
		}
		if (spawnRateInSeconds == 0.0f)
		{
			Debug.Log("Spawn rate not set in inspector, defaulting to 4.0f");
			spawnRateInSeconds = 4.0f;
		}

		//activePattern = Instantiate(spawnPatterns[0], originPoint, Quaternion.identity) as GameObject;
		//Debug.Log(activePattern);
		// activePattern.GetComponent<EnemyPattern>().SpawnEnemies();

	}

	// Update is called once per frame
	void Update()
	{
		timeSinceLastSpawn += Time.deltaTime;

		if (timeSinceLastSpawn >= spawnRateInSeconds)
		{
			Debug.Log(timeSinceLastSpawn);
			timeSinceLastSpawn = 0.0f;
			SpawnEnemy();

		}

	}
	
	/// <summary>
	/// Spawns a single random GameObject element of array enemies at a random location
	/// </summary>
	void SpawnEnemy()
	{
		float theta = Random.Range(0.0f, 360.0f);
		int enemyTypeToSpawn = Random.Range(0, enemies.Length);
		Debug.Log(theta);
		float x = transform.position.x + radius * Mathf.Cos(theta * Mathf.Deg2Rad);
		float y = transform.position.y + radius * Mathf.Sin(theta * Mathf.Deg2Rad);

		Vector3 spawnLocation = new Vector3(x, y, 0.0f);

		//Instantiate(enemies[enemyTypeToSpawn], spawnLocation, Quaternion.identity);
		Debug.DrawLine(transform.position, spawnLocation, Color.red, spawnRateInSeconds);
	}

	/// <summary>
	/// Spawns numberOfEnemiesToSpawn at a series of random locations.
	/// </summary>
	/// <param name="numberOfEnemiesToSpawn"></param>
	void SpawnEnemy(uint numberOfEnemiesToSpawn)
	{
		//Vector3 lastSpawnLocation = new Vector3();
		for (int i = 0; i < numberOfEnemiesToSpawn; i++)
		{
			float theta = Random.Range(0.0f, 360.0f);
			int enemyTypeToSpawn = Random.Range(0, enemies.Length);
			Debug.Log(theta);
			float x = transform.position.x + radius * Mathf.Cos(theta * Mathf.Deg2Rad);
			float y = transform.position.y + radius * Mathf.Sin(theta * Mathf.Deg2Rad);

			Vector3 spawnLocation = new Vector3(x, y, 0.0f);

			//Instantiate(enemies[enemyTypeToSpawn], spawnLocation, Quaternion.identity);
			Debug.DrawLine(transform.position, spawnLocation, Color.red, spawnRateInSeconds);
		}
	
	}
}
