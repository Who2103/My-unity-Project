using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedReset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ballphysic theBallMissed = other.gameObject.GetComponent<ballphysic>();

        if (theBallMissed)
        {
            print("Missed");
            theBallMissed.resetPosition();
        }
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
