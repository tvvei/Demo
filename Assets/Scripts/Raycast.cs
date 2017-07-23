using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
	public Rigidbody rd;
	public LayerMask layerMask = -1;
	public int force = 5;

	void Start () {
		rd = GetComponent<Rigidbody> ();
	}
	

	void Update () {
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
	}
}
