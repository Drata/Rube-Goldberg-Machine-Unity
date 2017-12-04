using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uTriggerJump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider c) {
        c.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse); 
    }
}
