using System.Collections;
using UnityEngine;

public class Followcamera : MonoBehaviour {
    public Transform playerTransfrom;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - playerTransfrom.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = playerTransfrom.position + offset;
    }
}
