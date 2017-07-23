using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour {
	public Rigidbody rigid;
	public int force = 5;

	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}

	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		rigid.AddForce (new Vector3 (h, 0, v) * force);
	}
}
