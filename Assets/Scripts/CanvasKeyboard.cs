using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasKeyboard : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerExitHandler
{
	private float delay = 0.2f;
	private bool isDown = false;
	private float lastIsDownTime;
	public Rigidbody rd;
	public Vector3 vector3;

	void start(){

	}

	void Update(){
		if (isDown) {
			if (Time.time - lastIsDownTime > delay) {
				rd.AddForce (vector3 * 6);
			}
		}
	}

	public void OnPointerDown(PointerEventData data){
		isDown = true;
		lastIsDownTime = Time.time;
	}

	public void OnPointerUp(PointerEventData data){
		isDown = false;
	}

	public void OnPointerExit(PointerEventData data)
	{
		isDown = false;
	}
}
