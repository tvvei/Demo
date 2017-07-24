using UnityEngine;

public class Keyboard : MonoBehaviour
{
	
	void Start ()
	{
		
	}

	void Update ()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		PlayerController.Instance.AddForce (h, v);
	}
}
