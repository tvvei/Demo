using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CanvasRocker : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler
{
	private RectTransform Joystick;
	private Vector3 a;
	public float radius = 40;
	public Rigidbody rigid;
	private Vector2 Mp;
	private float delay = 0f;
	private bool isDown = false;
	private float lastIsDownTime;
	public int force = 9;


	void Start ()
	{

		Joystick = this.gameObject.GetComponent<RectTransform> ();
		a = Joystick.position;
	}

	void Update(){
		if (isDown) {
			var v2 = Joystick.position - a;
			var direction = v2.normalized;
			var k = v2.magnitude / radius*2;
			if (Time.time - lastIsDownTime > delay) {
				rigid.AddForce (new Vector3 (direction.x, 0, direction.y) * k * force);
			}
		}
	}


	public void OnBeginDrag (PointerEventData data)
	{

	}

	public void OnDrag (PointerEventData data)
	{

		Joystick.position = data.position;

		float distance = Vector2.Distance (a, data.position);
		if (distance > radius) {			
			Joystick.position = a;

		} 

		isDown = true;
		lastIsDownTime = Time.time;

	}

	public void OnEndDrag (PointerEventData data)
	{
		Joystick.position = a;

	}
}
