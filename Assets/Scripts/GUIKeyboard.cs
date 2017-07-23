using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIKeyboard : MonoBehaviour {
	public Texture btnTexture1;
	public Texture btnTexture2;
	public Texture btnTexture3;
	public Texture btnTexture4;
	public Rigidbody rigid;
	public int force = 5;
	void Start () {
		
	}

	void Update () {
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 120, 50, 50), btnTexture1))
			rigid.AddForce (new Vector3 (0, 0, 10) * force);
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 60, 50, 50), btnTexture2))
			rigid.AddForce (new Vector3 (0, 0, -10) * force);
		if (GUI.RepeatButton (new Rect (Screen.width - 180, Screen.height - 60, 50, 50), btnTexture3))
			rigid.AddForce (new Vector3 (-10, 0, 0) * force);
		if (GUI.RepeatButton (new Rect (Screen.width - 60, Screen.height - 60, 50, 50), btnTexture4))
			rigid.AddForce (new Vector3 (10, 0, 0) * force);
	}
}
