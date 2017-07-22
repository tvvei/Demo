using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public float xOffset;  
	public float yOffset;  
	public RectTransform recTransform;  

	void Update ()
	{  
		Vector2 player2DPosition = Camera.main.WorldToScreenPoint (transform.position);  
		recTransform.position = player2DPosition + new Vector2 (xOffset, yOffset); 
	}
}
