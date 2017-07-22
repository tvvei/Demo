using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	float horizontalSpeed = 6.0f;
	float verticalspeed = 6.0f;
	
	// Update is called once per frame
	void Update () {
		float h = horizontalSpeed * Input.GetAxis ("Mouse X");
		float v = verticalspeed * Input.GetAxis ("Mouse Y");
		transform.Rotate (v, h, 0);

		if (Input.GetMouseButton (0))
			print ("左键按下");
		if (Input.GetMouseButtonDown (1))
			print ("右键按下");
		if (Input.GetMouseButtonUp (2))
			print ("中键弹起");
			print("当前鼠标位置为：" + Input.mousePosition);
	}
}
