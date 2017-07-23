using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
	public Rigidbody rd;
	public int force = 5;

	void Start ()
	{

	}

	void Update ()
	{
		float x = Input.GetAxis ("Mouse X");
		float y = Input.GetAxis ("Mouse Y");
		rd.AddForce (new Vector3 (x, 0, y) * force);
	}
}
