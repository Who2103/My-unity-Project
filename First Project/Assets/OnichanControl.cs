using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnichanControl : MonoBehaviour
{float rotationspeed = 120;
    float movementspeed = 3f;
    float gravity = 9.8f;
    float velocity = 0;
    float jump = 10f;
    Animator myAnimation;

    // Start is called before the first frame update
    void Start()
    {
        velocity -= gravity * Time.deltaTime;
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jump* Time.deltaTime;
            
            myAnimation.SetBool("isJumping", true);
            
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            myAnimation.SetBool("isWalking", false);
        }
            if (Input.GetKey(KeyCode.UpArrow))
        {
            myAnimation.SetBool("isWalking", true);
            myAnimation.SetBool("isJumping", false);
            transform.position = transform.position  +  transform.forward *movementspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -=  transform.forward * movementspeed * Time.deltaTime;
            myAnimation.SetBool("isWalking", true);
            myAnimation.SetBool("isJumping", false);
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