using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody shipBody;
    AudioSource shipSound;
    // Start is called before the first frame update
    void Start()
    {
        shipBody = GetComponent<Rigidbody>();
        shipSound = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        ShipTrust();
        ShipSteering();
    }

/*    private void ProcessInput()
    {

    }*/

    private void ShipSteering()
    {
        shipBody.freezeRotation = true; //assume manual control of movement
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) //steering error
        {
            shipBody.AddForce(Vector3.down);
            print("Mayday! Mayday!");
        }
        else if (Input.GetKey(KeyCode.A)) //turn left
        {
            transform.Rotate(Vector3.forward);
            print("Heading to Port!");
        }
        else if (Input.GetKey(KeyCode.D)) //turn right
        {
            transform.Rotate(Vector3.back);
            print("Heading to Starboard!");
        }

        shipBody.freezeRotation = false; // resume physics control of movement
    }

    private void ShipTrust()
    {
        if (Input.GetKey(KeyCode.Space)) //propulsion system
        {
            shipBody.AddRelativeForce(Vector3.up);
            if (shipSound.isPlaying == false)
            {
                shipSound.Play();
            }
            print("Thrusters engaged!");
        }
        if (shipSound.isPlaying && Input.GetKey(KeyCode.Space) == false) //stop sound when thrust cut
        {
            shipSound.Stop();
        }
    }
}
