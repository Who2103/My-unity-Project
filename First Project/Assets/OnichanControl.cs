using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnichanControl : MonoBehaviour
{float rotationspeed = 120;
    float movementspeed = 0.1f;
    float gravity = 9.8f;
    float velocity = 0;
    // Start is called before the first frame update
    void Start()
    {
        velocity -= gravity * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward *movementspeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0), -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0), rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.C))
            transform.position += Vector3.down * Time.deltaTime;
        
      
    }
}