using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyPattern : MonoBehaviour {

	public List<GameObject> enemiesToSpawn = new List<GameObject>();
	public List<Vector3> spawnPositions = new List<Vector3>();

	void Awake()
	{
		//GetComponent<CircleCollider2D>().bounds.

		int x = 0;
		for (int i = 0; i < transform.childCount; i++)
		{
			if (transform.GetChild(i).GetComponent<Enemy>())
			{
				Debug.Log(transform.GetChild(i).name);
				enemiesToSpawn.Add(transform.GetChild(i).gameObject);
				spawnPositions.Add(transform.GetChild(i).position);
				x++;
			}
		}
		Debug.Log(enemiesToSpawn.Count);
		Debug.Log(spawnPositions.Count);
	}
	// Use this for initialization
	void Start ()
	{
		

	}

	public void SpawnEnemies()
	{
		for (int i = 0; i < enemiesToSpawn.Count; i++)
		{
			enemiesToSpawn[i].transform.position = spawnPositions[i];
			enemiesToSpawn[i].SetActive(true);
		}
	}


	public bool HasActiveEnemy()
	{
		bool hasActiveEnemyInList = false;

		for (int i = 0; i < enemiesToSpawn.Count; i++)
		{
			if(enemiesToSpawn[i].gameObject.activeSelf)
			{
				hasActiveEnemyInList = true;
			}
		}
		return hasActiveEnemyInList;
	}

}
