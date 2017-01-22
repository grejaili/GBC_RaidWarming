using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour {

	public Transform target;
	public float xOffset = 3;
	public float yOffset = 3;
	public float zOffset = 16;

	void Update ()
	{
		Vector3 newPos = target.position;
		newPos.x += xOffset;
		newPos.y += yOffset;
		newPos.z += zOffset;

		transform.position = newPos;
	}
}
