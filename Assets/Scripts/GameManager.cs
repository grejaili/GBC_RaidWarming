using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager _instance = null;

	public float radius;
	public float spawnRateInSeconds;
	public float maxPopulation = 30;
	public GameObject[] enemies;
	Vector3 originPoint = Vector3.zero;
	private float timeSinceLastSpawn = 0.0f;
	private float timeOfLastSpawn;

	List<GameObject> enemyPopulation;
	List<GameObject> wavePopulation;


	// Use this for initialization
	void Start ()
	{
		enemyPopulation = new List<GameObject>();
		wavePopulation = new List<GameObject>();

		

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
			SpawnEnemy(2);
		}

		// Num keys to Change Weapon
		if (Input.GetKeyDown(KeyCode.Alpha1))
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

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}

		// Scroll to Change Weapon
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			Debug.Log(UI_Manager.instance.GetBulletType());

			if (UI_Manager.instance.GetBulletType() < 3)
			{
				UI_Manager.instance.SetBulletType(
									UI_Manager.instance.GetBulletType() + 1);
			}
			else // Cycle back to first type
			{
				UI_Manager.instance.SetBulletType(0);
			}
		}
		else if (Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			//Debug.Log(UI_Manager.instance.GetBulletType());

			if (UI_Manager.instance.GetBulletType() > 0)
			{
				UI_Manager.instance.SetBulletType(
									UI_Manager.instance.GetBulletType() - 1);
			}
			else // Cycle back to last type
			{
				UI_Manager.instance.SetBulletType(3);
			}
		}

	}
	
	/// <summary>
	/// Spawns a single random GameObject element of array enemies at a random location
	/// </summary>
	//void SpawnEnemy()
	//{
	//	float theta = Random.Range(0.0f, 360.0f);
	//	int enemyTypeToSpawn = Random.Range(0, enemies.Length);
	//	//Debug.Log(theta);
	//	float rando = Random.Range(radius / 2, radius * 2);
	//	float x = transform.position.x + rando * Mathf.Cos(theta * Mathf.Deg2Rad);
	//	float z = transform.position.z + rando * Mathf.Sin(theta * Mathf.Deg2Rad);

	//	Vector3 spawnLocation = new Vector3(x, 0.0f, z);

	//	for (int i = 0; i < enemyPopulation.Count; i++)
	//	{
	//		if (!enemyPopulation[i].activeInHierarchy)
	//		{
	//			GameObject newEnemy = enemyPopulation[i];
	//			newEnemy.transform.position = spawnLocation;
	//			newEnemy.SetActive(true);
	//			break;
	//		}
	//	}

	//	///Instantiate(enemies[enemyTypeToSpawn], spawnLocation, Quaternion.identity);
	//	//Debug.DrawLine(transform.position, spawnLocation, Color.red, spawnRateInSeconds);
	//}

	/// <summary>
	/// Spawns numberOfEnemiesToSpawn at a series of random locations.
	/// </summary>
	/// <param name="numberOfEnemiesToSpawn"></param>
	/// 
	void SpawnEnemy(uint numberOfEnemiesToSpawn)
	{
		
		if (SceneManager.GetActiveScene().buildIndex == 1)
		{
			//Vector3 lastSpawnLocation = new Vector3();
			for (int i = 0; i < numberOfEnemiesToSpawn; i++)
			{
				for (int j = 0; j < enemyPopulation.Count; j++)
				{
					//Debug.Log(enemyPopulation[j]);
					if (!enemyPopulation[j].activeInHierarchy)
					{
						float theta = Random.Range(0.0f, 360.0f);
						int enemyTypeToSpawn = Random.Range(0, enemies.Length);
						float rando = Random.Range(radius / 2, radius * 2);
						float x = transform.position.x + rando * Mathf.Cos(theta * Mathf.Deg2Rad);
						float z = transform.position.z + rando * Mathf.Sin(theta * Mathf.Deg2Rad);

						Vector3 spawnLocation = new Vector3(x, 0.0f, z);
						GameObject newEnemy = enemyPopulation[j];
						newEnemy.transform.position = spawnLocation;
						newEnemy.SetActive(true);
						break;
					}
				}
			}
		}
		
	}


	public void OnSceneTransition()
	{
		//Debug.Log("This should appear every time the player dies");
		// Create host of enemies in the wing
		enemyPopulation.Clear();
		for (int i = 0; i < maxPopulation; i++)
		{
				int enemyType = Random.Range(0, enemies.Length);
				GameObject enemy = Instantiate(enemies[enemyType]);
				enemy.SetActive(false);
				enemyPopulation.Add(enemy);
		}

		//Debug.Log(SceneManager.GetActiveScene().name);
	}
	public static GameManager instance
	{
		get { return _instance; }
		set { _instance = value; }
	}

}
