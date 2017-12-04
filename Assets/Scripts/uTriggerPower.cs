using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uTriggerPower : MonoBehaviour
{
    public int force = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        c.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
