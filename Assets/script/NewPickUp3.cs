using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPickUp3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("String" + Time.time);
      
	}
    
    private IEnumerator WaitAndPrint(float waitTime){
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint" + Time.time);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
