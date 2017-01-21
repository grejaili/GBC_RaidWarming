using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager _instance = null;

	public float radius;
	public float spawnRateInSeconds;
	public GameObject[] enemies;
	Vector3 originPoint = Vector3.zero;
	private float timeSinceLastSpawn = 0.0f;
	private float timeOfLastSpawn;


	// Use this for initialization
	void Start ()
	{
		// Checks if a GameManager exists, and destroys the second copy.
		if (instance)
		{
			DestroyImmediate(gameObject);
		}
		else
		{
			instance = this;

			DontDestroyOnLoad(this);
		}

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
	}

	// Update is called once per frame
	void Update()
	{
		timeSinceLastSpawn += Time.deltaTime;

		if (timeSinceLastSpawn >= spawnRateInSeconds)
		{
			//Debug.Log(timeSinceLastSpawn);
			timeSinceLastSpawn = 0.0f;
			SpawnEnemy();

		}


		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			UI_Manager.instance.SetBulletType(0);
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			UI_Manager.instance.SetBulletType(1);
		}
		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			UI_Manager.instance.SetBulletType(2);
		}
		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			UI_Manager.instance.SetBulletType(3);
		}
	}
	
	/// <summary>
	/// Spawns a single random GameObject element of array enemies at a random location
	/// </summary>
	void SpawnEnemy()
	{
		float theta = Random.Range(0.0f, 360.0f);
		int enemyTypeToSpawn = Random.Range(0, enemies.Length);
		//Debug.Log(theta);
		float x = transform.position.x + radius * Mathf.Cos(theta * Mathf.Deg2Rad);
		float z = transform.position.z + radius * Mathf.Sin(theta * Mathf.Deg2Rad);

		Vector3 spawnLocation = new Vector3(x, 0.0f, z);

		Instantiate(enemies[enemyTypeToSpawn], spawnLocation, Quaternion.identity);
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


	public static GameManager instance
	{
		get { return _instance; }
		set { _instance = value; }
	}
}
