using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour {
	public Rigidbody rd;
	public int force = 5;

	void Start () {
		rd = GetComponent<Rigidbody> ();
	}

	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		rd.AddForce (new Vector3 (h, 0, v) * force);
	}
}
