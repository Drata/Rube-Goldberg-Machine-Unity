using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uJump : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        if (rb == null) {
            Debug.Log("Rigidbody not found.");
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Salto.");
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
	}
}
