using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood : MonoBehaviour {
	public GameObject Object;
	void Start ()
	{
		
	}

	void Update (){
		

	}
	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject == Object) {
			
			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
			Destroy (collider.gameObject, 3);
		}
	}
}