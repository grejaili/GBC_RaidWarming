using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTilt : MonoBehaviour {

	public float tiltAngle = 20;
	Player player;
	
	void Start()
	{
		player = GetComponentInParent<Player>();
	}

	void Update ()
	{
		float forward = player.GetForwardInput();
		float lateral = player.GetLateralInput();

		// Forward / Backward Tilt
		if (forward > 0)
		{
			Quaternion DownAngle = Quaternion.Euler(-tiltAngle, transform.rotation.eulerAngles.y, 0);
			transform.rotation = Quaternion.Lerp(transform.rotation, DownAngle, Time.deltaTime);
		}
		if (forward < 0)
		{
			Quaternion UpAngle = Quaternion.Euler(tiltAngle, transform.rotation.eulerAngles.y, 0);
			transform.rotation = Quaternion.Lerp(transform.rotation, UpAngle, Time.deltaTime);
		}

		// Lateral Tilt
		if (lateral > 0)
		{
			Quaternion RightAngle = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -tiltAngle);
			transform.rotation = Quaternion.Lerp(transform.rotation, RightAngle, Time.deltaTime);
		}
		if (lateral < 0)
		{
			Quaternion LeftAngle = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, tiltAngle);
			transform.rotation = Quaternion.Lerp(transform.rotation, LeftAngle, Time.deltaTime);
		}

		if (lateral == 0 && forward == 0)
		{
			Quaternion Natural = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
			transform.rotation = Quaternion.Lerp(transform.rotation, Natural, Time.deltaTime);
		}

	}//update
}
