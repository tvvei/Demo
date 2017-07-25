using UnityEngine;

public class Attack : MonoBehaviour
{
	void Start ()
	{
		
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "prefab") {
			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
			mr.material.color = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 0.5f);
		}
	}
}
