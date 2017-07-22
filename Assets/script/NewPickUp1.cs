using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPickUp : MonoBehaviour {
    private IEnumerator coroutine;
	// Use this for initialization
	void Start () {
        //StartCoroutine(Pop(Time.deltaTime));
        //StartCoroutine(Bop(Time.deltaTime));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Pop(float waitTime) {
        while (transform.localScale.x <= 3) {
            yield return new WaitForSeconds(waitTime);
            transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
        }
        StartCoroutine(Bop(Time.deltaTime));
    }
    IEnumerator Bop(float waitTime) {
        while (transform.localScale.x >= 1)
        {
            yield return new WaitForSeconds(waitTime);
            transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F);
        }
        StartCoroutine(Pop(Time.deltaTime));
    }
}
