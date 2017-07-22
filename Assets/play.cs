using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class play : MonoBehaviour {
	public LayerMask layerMask = -1;
	public Texture btnTexture1;
	public Texture btnTexture2;
	public Texture btnTexture3;
	public Texture btnTexture4;
	public player player;
	public GUISkin guiSkin;
	public Vector2 center = Vector2.zero;
	public float radius = 50;
	public Texture background;
	public int force = 5;
	private Vector2 pos = new Vector2 (100, Screen.height - 200);
	private Vector2 size = new Vector2 (100, 100);
	private Vector2 offset = Vector2.zero;
	private Vector2 backgroundSize = new Vector2 (200, 200); 
	private bool isDown;
	private Rigidbody rd;
	public InputMode inputmode;
	public enum InputMode{
		keyboard,
		mouse,
		ray,
		button1,
		rocker1,
		button,
		rocker
	}


	private Ygan ygan;
	public rocker rocker;
	public ButUp butUp;
	public GameObject image;
	public GameObject panel;


	void Start () {
		ygan = GetComponent<Ygan> ();
		rd = GetComponent<Rigidbody> ();
		center = pos + 0.5f * size;

	}
	void OnGUI(){
		if (inputmode == InputMode.rocker) {
			image.SetActive (true);
		} else {
			image.SetActive (false);
		}

		if (inputmode == InputMode.button) {
			panel.SetActive (true);
		} else {
			panel.SetActive (false);
		}


		if (inputmode == InputMode.mouse) {
			float x = Input.GetAxis ("Mouse X");
			float y = Input.GetAxis ("Mouse Y");
			rd.AddForce (new Vector3 (x, 0, y) * force);

		} else if (inputmode == InputMode.keyboard) {
			float h = Input.GetAxis ("Horizontal");
			float v = Input.GetAxis ("Vertical");
			rd.AddForce (new Vector3 (h, 0, v) * force);

		} else if (inputmode == InputMode.ray) {
			if (Input.GetMouseButton (0)) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				Debug.DrawLine (ray.origin, ray.origin + 10 * ray.direction, Color.red, 3);
				RaycastHit hit;
				if (Physics.Raycast (ray, out hit, 100, layerMask)) {
					Debug.Log (hit.collider.name + " : " + hit.point);
					Vector3 a = hit.point - rd.position;
					Debug.DrawLine (rd.transform.position, rd.transform.position + a, Color.blue);
					Vector3 b = Vector3.ProjectOnPlane (a, Vector3.up);
					Debug.DrawLine (rd.transform.position, rd.transform.position + b, Color.green);
					rd.AddForce (Vector3.Normalize (b) * force);
				}
			}
			
		} else if (inputmode == InputMode.button1) {
			if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 120, 50, 50), btnTexture1))
				rd.AddForce (new Vector3 (0, 0, 10) * force);
			if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 60, 50, 50), btnTexture2))
				rd.AddForce (new Vector3 (0, 0, -10) * force);
			if (GUI.RepeatButton (new Rect (Screen.width - 180, Screen.height - 60, 50, 50), btnTexture3))
				rd.AddForce (new Vector3 (-10, 0, 0) * force);
			if (GUI.RepeatButton (new Rect (Screen.width - 60, Screen.height - 60, 50, 50), btnTexture4))
				rd.AddForce (new Vector3 (10, 0, 0) * force);
			
		} else if (inputmode == InputMode.rocker) {	
			rocker.enabled = true;

		} else if (inputmode == InputMode.button) {
			butUp.enabled = true;
		}

		if (inputmode == InputMode.rocker1) {
			
//			ygan.enabled = true;

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

		else {
			ygan.enabled = false;
		}
	}
	
	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "prefab") {
			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
			mr.material.color = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 0.5f);
			Destroy (collider.gameObject, 3);
		}
	}
}