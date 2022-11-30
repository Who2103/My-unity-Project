using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        ballphysic theBallIntheGoal = other.gameObject.GetComponent<ballphysic>();

        if (theBallIntheGoal)
            theBallIntheGoal.resetPosition();


   

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
