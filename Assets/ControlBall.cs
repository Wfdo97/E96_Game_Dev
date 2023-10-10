using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour
{
	public float force = 5f;

	void MoveTop()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			GetComponent<Rigidbody>().AddForce(Vector3.right * force);

		if (Input.GetKey(KeyCode.DownArrow))
			GetComponent<Rigidbody>().AddForce(Vector3.left * force);

		if (Input.GetKey(KeyCode.LeftArrow))
			GetComponent<Rigidbody>().AddForce(Vector3.forward * force);

		if (Input.GetKey(KeyCode.RightArrow))
			GetComponent<Rigidbody>().AddForce(Vector3.back * force);
	}

	void FixedUpdate()
	{
		MoveTop();
	}
}
