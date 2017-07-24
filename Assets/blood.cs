using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour {
	public Scrollbar size;
	public GameObject cube;
	public float hp = 1;

	void Start ()
	{
		Scrollbar scrollbar = GetComponent<Scrollbar> ();
		scrollbar.size = 1;

		transform.position = new Vector3 (cube.transform.position.x, 1, cube.transform.position.z);

	}

	void Update (){
//		float coll = PickUp.coll;
//		size = size*(1-coll/hp) ;


		if (cube == null) {
			gameObject.SetActive (false);
		}

	}

}