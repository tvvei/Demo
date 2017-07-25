using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour {

	public GameObject cube;


	void Start ()
	{
		transform.position = new Vector3 (cube.transform.position.x, 1, cube.transform.position.z);

	}

	void Update (){

		if (cube == null) {
			gameObject.SetActive (false);
		}

	}

}