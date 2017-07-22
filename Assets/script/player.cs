using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public LayerMask layerMask = -1;
	public int force = 9;
	private Rigidbody rd;

	void Start ()
	{
		rd = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		if (Input.GetMouseButton (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Debug.DrawLine (ray.origin, ray.origin + 10 * ray.direction, Color.red, 3);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100, layerMask)) {
				Debug.Log (hit.collider.name + " : " + hit.point);
				Vector3 a = hit.point - rd.position;
				Debug.DrawLine (rd.transform.position, rd.transform.position + a, Color.blue);
				Vector3 b = Vector3.ProjectOnPlane(a, Vector3.up);
				Debug.DrawLine (rd.transform.position, rd.transform.position + b, Color.green);
				rd.AddForce (Vector3.Normalize(b) * force);
			}
		}




		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		float x = Input.GetAxis("Mouse X");
		float y = Input.GetAxis("Mouse Y");

		rd.AddForce (new Vector3 (h, 0, v) * force);
//		rd.AddForce (new Vector3 (x, 0, y) * force);
	}

	//    void OnCollisionEnter(Collision collision){
	//        if(collision.collider.tag == "prefab") {
	//            Destroy(collision.collider.gameObject);
	//        }
	//    }

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "prefab") {
//			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
//			mr.material.color = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 0.5f);
//			Destroy (collider.gameObject, 3);
		}
	}
}
