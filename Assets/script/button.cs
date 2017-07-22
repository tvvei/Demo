using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
	public int force = 5;
	private Rigidbody rd;

	public Rect windowRect = new Rect (10, 10, 180, 150);

	public Texture btnTexture1;
	public Texture btnTexture2;
	public Texture btnTexture3;
	public Texture btnTexture4;
//	static void bool RepeatButton(Rect posision,Texture image);

	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody> ();
	}

	void OnGUI(){
//		windowRect = GUI.Window(0,windowRect,WindowFunction,"widow");

//
//		if (GUI.Button (new Rect (100, 10, 50, 50), btnTexture1))
//			Debug.Log("向上");
//		if (GUI.Button (new Rect (100, 70, 50, 50), btnTexture2))
//			Debug.Log("向下");
//		if (GUI.Button (new Rect (40, 70, 50, 50), btnTexture3))
//			Debug.Log("向左");
//		if (GUI.Button (new Rect (160, 70, 50, 50), btnTexture4))
//			Debug.Log("向右");


		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 120, 50, 50), btnTexture1)) 
			rd.AddForce (new Vector3 (0, 0, 10) * force);
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 60, 50, 50), btnTexture2))
			rd.AddForce (new Vector3 (0, 0, -10) * force);
		if (GUI.RepeatButton (new Rect (Screen.width - 180, Screen.height - 60, 50, 50), btnTexture3))
			rd.AddForce (new Vector3 (-10, 0, 0) * force);
		if (GUI.RepeatButton (new Rect (Screen.width - 60, Screen.height - 60, 50, 50), btnTexture4))
			rd.AddForce (new Vector3 (10, 0, 0) * force);
		
	}

//	void WindowFunction(int windowID){
//		GUI.Button (new Rect (65, 10, 50, 50), btnTexture1);
//		GUI.Button (new Rect (65, 70, 50, 50), btnTexture2);
//		GUI.Button (new Rect (5, 70, 50, 50), btnTexture3);
//		GUI.Button (new Rect (125, 70, 50, 50), btnTexture4);
//
//		GUI.DragWindow (new Rect (0, 0, 180, 30));
//	}

	
	// Update is called once per frame
	void Update () {
		
//		float h = Input.GetAxis ("Horizontal");
//		float v = Input.GetAxis ("Vertical");
//
//		rd.AddForce (new Vector3 (h, 0, v) * force);
//


			
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "prefab") {
//			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
//			mr.material.color = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 0.5f);
//			Destroy (collider.gameObject, 3);
		}
	}




}
