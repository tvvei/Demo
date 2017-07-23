using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIRocker : MonoBehaviour {
	private Vector2 backgroundSize = new Vector2 (200, 200); 
	private bool isDown;
	public Vector2 center = Vector2.zero;
	private Vector2 pos = new Vector2 (100, Screen.height - 200);
	private Vector2 size = new Vector2 (100, 100);
	public float radius = 50;
	private Vector2 offset = Vector2.zero;
	public GUISkin guiSkin;
	public Rigidbody rd;
	public int force = 5;
	public player player;

	void Start () {
//		rd = GetComponent<Rigidbody> ();
		center = pos + 0.5f * size;
	}
	

	void Update () {
		GUI.Box (new Rect (center - 0.5f * backgroundSize, backgroundSize), "", guiSkin.box);

		if (GUI.RepeatButton (new Rect (pos, size), "", guiSkin.button) && !isDown) {
			Vector2 mousePos = new Vector2 (Input.mousePosition.x, Screen.height - Input.mousePosition.y);
			offset = pos - mousePos;
			isDown = true;
		}

		if (isDown) {
			pos = new Vector2 (Input.mousePosition.x, Screen.height - Input.mousePosition.y) + offset;

			if (Vector2.Distance (center, pos + 0.5f * size) > radius) {
				pos = center - 0.5f * size + (pos - center).normalized * radius;
			}

			var v2 = pos + 0.5f * size - center;
			var direction = v2.normalized;
			var k = v2.magnitude / radius;

			rd.AddForce (new Vector3 (direction.x, 0, -direction.y) * k * player.force);
		}


		if (Input.GetMouseButtonUp (0) && isDown) {
			pos = center - 0.5f * size;
			isDown = false;
		}
	}
}
