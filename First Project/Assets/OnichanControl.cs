using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnichanControl : MonoBehaviour
{float rotationspeed = 180;
    float movementspeed = 6f;
    float gravity = 9.8f;
    float velocity = 0;
    float jump = 10f;
    float jumpAnimDuration = 1f;
    Animator myAnimation;
    float jumpTimer = 0f;

    Rigidbody theBall;
    // Start is called before the first frame update
    void Start()
    {
        ballphysic theBallScript = FindObjectOfType<ballphysic>();

        theBall = theBallScript.gameObject.GetComponent<Rigidbody>();
        velocity -= gravity * Time.deltaTime;
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpTimer = jumpAnimDuration;
        }

        if(jumpTimer > 0)
        {
            myAnimation.SetBool("isJumping", true);
            transform.position += Vector3.up * jump * Time.deltaTime;
            jumpTimer -= Time.deltaTime;
        }
        else
        {
            myAnimation.SetBool("isJumping", false);
        }

       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myAnimation.SetBool("isWalking", true);
            transform.position = transform.position  +  transform.forward *movementspeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -=  transform.forward * movementspeed * Time.deltaTime;
            myAnimation.SetBool("isWalking", true);
        }
        else
        {
            myAnimation.SetBool("isWalking", false);
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

        if (Input.GetKeyDown(KeyCode.B))
        {
            theBall.AddExplosionForce(1250, transform.position +  new Vector3(0, -2,-1), 4);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            theBall.AddExplosionForce(1000, transform.position, 3);
        }
    }
}