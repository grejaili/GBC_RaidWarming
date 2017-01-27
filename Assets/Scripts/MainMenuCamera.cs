using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour {


	// Use this for initialization
	void Start()
	{
		GetComponent<Rigidbody>().AddForceAtPosition(new Vector3(25f, 25f, 25f), new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f)));

	}


}
