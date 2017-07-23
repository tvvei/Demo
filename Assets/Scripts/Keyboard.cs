using UnityEngine;

public class Keyboard : MonoBehaviour
{
	public Rigidbody rigid;
	public int force = 5;

	void Start ()
	{
		
	}

	void Update ()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		rigid.AddForce (new Vector3 (h, 0, v) * force);
	}
}
