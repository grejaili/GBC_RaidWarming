using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour {

	public float rotationSpeed = 1;
	public float x = 0;
	public float y = 1;
	public float z = 0;
	
	void Start () {
		
	}
	
	
	void Update () {

		Vector3 spin = new Vector3(x, z, y);
		transform.Rotate(spin * rotationSpeed);
	}
}
