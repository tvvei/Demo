using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gui : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Texture2D textureToDisplay;
	public Texture btnTexture;
	private string stringToEdit = "Hello World"	;
	private string passwordToEdit = "My Password";
	private string stringToEdit2 = "Hello Word\nI've got 2 lines...";
	public Texture aTextrue;
	private bool toggleTxt = false;
	private bool toggleImg = false;


	void OnGUI(){
		
		GUI.Label(new Rect( 10, 10, 100, 20),"Hello World!");

		GUI.Label (new Rect(10, 40, textureToDisplay.width, textureToDisplay.height),
			textureToDisplay);	

		GUI.Box (new Rect (60, 40, 110, 60),"This is a titla");

		if (!btnTexture) {
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}
		if (GUI.Button (new Rect (100, 100, 110, 110), btnTexture))
			Debug.Log ("Clicked the button with an image");
		if(GUI.Button(new Rect(190,150,200,160),"Click"))
			Debug.Log("Clicked the button with text");

		if (!btnTexture) {
			Debug.LogError ("Please assign a texture on the inspector");
			return;
		}
		if (GUI.RepeatButton (new Rect (300, 150, 310, 160), btnTexture))
			Debug.Log ("Clicked the button with an image");
		if (GUI.RepeatButton (new Rect (250, 200, 260, 210), "Click"))
			Debug.Log ("Clicked the button with text");
		
		stringToEdit = GUI. TextField(new Rect (200, 10, 230, 20),stringToEdit,25);

		passwordToEdit = GUI.PasswordField (new Rect (200, 30, 230, 40), passwordToEdit, "*" [0], 25);

		stringToEdit2 = GUI.TextArea (new Rect (450, 30, 480, 60), stringToEdit2, 200);

		if (!aTextrue) {
			Debug.LogError ("Please assign a textture in the inspector.");
			return;
		}
		toggleTxt = GUI.Toggle (new Rect (10, 200, 20, 220), toggleTxt, "A Toggle text");
		toggleImg = GUI.Toggle (new Rect(10,230,30,250),toggleImg,aTextrue);
		
	}
}
