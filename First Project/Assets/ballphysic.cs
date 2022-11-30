using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballphysic : MonoBehaviour
{
    Rigidbody ourRigidBody;
    private object transforms;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    internal void resetPosition()
    {
        transform.position = new Vector3(-2, 1, 1);
        ourRigidBody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
