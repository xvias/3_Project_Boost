using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody rocketBody;
    // Start is called before the first frame update
    void Start()
    {
        rocketBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
/*        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            print("Mayday! Mayday!");
            
        }*/
        if (Input.GetKey(KeyCode.Space)) //separate to allow independent and simultaneous with turn keys
        {
            rocketBody.AddRelativeForce(Vector3.up);
            print("Thrusters engaged!");
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            print("Mayday! Mayday!");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print("Heading to Port!");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Heading to Starboard!");
        }

    }
}
