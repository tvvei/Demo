using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour {
	public Transform cube;
	public Vector3 trans = new Vector3(0,1,0);
	private Scrollbar scr;
	public float hp;



	void Start ()
	{
		transform.position = new Vector3 (cube.transform.position.x, 2, cube.transform.position.z);

	}

	void Update (){
		if (cube == null) {
			gameObject.SetActive (false);
		}

	}


}