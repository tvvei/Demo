using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private int direction = 1;
    private IEnumerator coroutine;

    void Start()
    {       
//	StartCoroutine(Pop(Time.deltaTime));
//        StartCoroutine(Bop(Time.deltaTime));  
	}
    
    void Update()
    {



//
        transform.Rotate (new Vector3 (1, 1, 1));
////
//		/// 
//        if (transform.localScale.x > 3) {
//        	direction = -1;
//        } else if (transform.localScale.x < 1) {
//        	direction = 1;
//        }
//        transform.localScale += direction * new Vector3 (0.1F, 0.1F, 0.1F);
    }

//

    IEnumerator Pop (float waitTime)
    {
        while (transform.localScale.x <= 3)
        {
            yield return new WaitForSeconds(waitTime);
            transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
        }
        StartCoroutine(Bop(Time.deltaTime));
    }

    IEnumerator Bop(float waitTime)
    {
        while (transform.localScale.x >= 1)
        {
            yield return new WaitForSeconds(waitTime);
            transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F);
        }
        StartCoroutine(Pop(Time.deltaTime));
    }
}