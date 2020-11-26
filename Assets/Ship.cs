using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody rocketBody;
    AudioSource shipSound;
    // Start is called before the first frame update
    void Start()
    {
        rocketBody = GetComponent<Rigidbody>();
        shipSound = GetComponent<AudioSource>();
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
            if (shipSound.isPlaying == false) {
            shipSound.Play();
            }

            print("Thrusters engaged!");
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            print("Mayday! Mayday!");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
            print("Heading to Port!");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back);
            print("Heading to Starboard!");
        }

    }
}
