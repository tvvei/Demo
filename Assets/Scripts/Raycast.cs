using UnityEngine;

public class Raycast : MonoBehaviour
{
	public LayerMask layerMask = -1;
	public Rigidbody rigid;
	public int force = 5;

	void Start ()
	{

	}

	void Update ()
	{
		if (Input.GetMouseButton (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			#if UNITY_EDITOR
			Debug.DrawLine (ray.origin, ray.origin + 10 * ray.direction, Color.red, 3);
			#endif
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100, layerMask)) {
				Vector3 a = hit.point - rigid.position;
				Vector3 b = Vector3.ProjectOnPlane (a, Vector3.up);
				rigid.AddForce (Vector3.Normalize (b) * force);
				#if UNITY_EDITOR
				Debug.DrawLine (rigid.transform.position, rigid.transform.position + a, Color.blue);
				Debug.DrawLine (rigid.transform.position, rigid.transform.position + b, Color.green);
				#endif
			}
		}
	}
}
