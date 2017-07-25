using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ablood : MonoBehaviour
{
	
	public Image hps;
	public GameObject cube;
	private float hp;

	void Start ()
	{
		hps.fillAmount = 1f;
		hp = cube.GetComponent<PickUp> ().hp;
	}

	void Update ()
	{
		
		float coll = cube.GetComponent<PickUp> ().coll;

		if (coll != 0) {
			hps.fillAmount = 1 - coll / hp;

		} else {
			return;
		}

	}
}
