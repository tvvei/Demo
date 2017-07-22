using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schen : MonoBehaviour
{
	public GameObject cubePrefab;

	void Start ()
	{
		GameObject go = Instantiate<GameObject> (cubePrefab);
		go.transform.position = new Vector3(0,0,0);
		go.AddComponent<PickUp> ();

		StartCoroutine(DelayDestroy(go, 3));
	}

	IEnumerator DelayDestroy(GameObject go, float delay){
		yield return new WaitForSeconds(delay);
		Destroy (go);
	}



	
}
