using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layout : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI () {
//		GUILayout.Button ("I amkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk");
		GUILayout.BeginArea (new Rect (10, Screen.height*0.5f, 400, 200));
		GUILayout.Button ("cccccccdddddddddddddeeeeeeeeeffffffff", GUILayout. MaxHeight (300));
		GUILayout.BeginHorizontal ();
		GUILayout.Button("aaeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeaa");
		GUILayout.Box ("qqqqqqqqqqqqqqqqqqq");
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();
	}
}
