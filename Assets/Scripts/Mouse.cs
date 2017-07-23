using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
	public Rigidbody rigid;
	public int force = 5;

	void Start () {
		rigid = GetComponent<Rigidbody> ();
	}

	void Update () {
		float x = Input.GetAxis ("Mouse X");
		float y = Input.GetAxis ("Mouse Y");
		rigid.AddForce (new Vector3 (x, 0, y) * force);
	}
}
