using UnityEngine;

public class Followcamera : MonoBehaviour
{
	public Transform playerTransfrom;
	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - playerTransfrom.position;
	}

	void Update ()
	{
		transform.position = playerTransfrom.position + offset;
	}
}
