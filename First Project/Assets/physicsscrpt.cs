using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsscrpt : MonoBehaviour
{
    Rigidbody OurRigidBody;
    // Start is called before the first frame update
    void Start()
    {
       OurRigidBody =  GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            OurRigidBody.AddExplosionForce(1000,transform.position+Vector3.down +Vector3.back,3); 
        }
    }
}
