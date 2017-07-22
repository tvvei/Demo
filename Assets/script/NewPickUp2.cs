using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New1 : MonoBehaviour {
    private int direction = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(1, 1, 1));
        if (transform.localScale.x > 3) {
            direction = -1;
        }
        else if (transform.localScale.x < 1) { 
            direction = 1;
        }
        transform.localScale += direction * new Vector3(0.1F, 0.1F, 0.1F);
	}
}
