using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour {
	Vector3 direction = Vector3.forward;
	float speed = 5.0f;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += direction * speed * Time.deltaTime;
	}
}
