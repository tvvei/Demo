using UnityEngine;

public class Mouse : MonoBehaviour
{

	void Start ()
	{

	}

	void Update ()
	{
		float x = Input.GetAxis ("Mouse X");
		float y = Input.GetAxis ("Mouse Y");

		PlayerController.Instance.AddForce (x, y);
	}
}
