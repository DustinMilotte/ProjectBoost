using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // This is where we will list the public and private variables for the Rocket class

    public float thrustPower;
    public float turnspeed;

    private Rigidbody christanWoodRigidbody;
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // store the rocket's starting position and rotation so we can reset it if necessary
        startingPosition = transform.position;
        startingRotation = transform.localRotation;

        // get a reference to the rigidbody component attached to the rocket and store it in our christianWoodRigidbody variable
        christanWoodRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // apply thrust and rotation on each frame
        Thrust();
        Rotate();

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetRocket();
        }
    }

    private void Thrust()
    {
        // if the space bar is pressed currently, GetKey will run on every frame that the key is down
        if (Input.GetKey(KeyCode.Space))
        {
            // apply upward force to our rocket by using the "AddRelativeForce" method on it's rigidbody
            christanWoodRigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * thrustPower);
        }

        // if the space bar went down this frame start playing the engine sound, GetKeyDown will run only on the exact frame the key went down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }
        // else if the space bar came up this frame stop playing the engine sound, GeyKeyUp will run on the frame the key came up
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            audioSource.Stop();
        }
    }

    private void Rotate()
    {
        christanWoodRigidbody.freezeRotation = true;

        // if the A key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            // Rotate the rocket counterclockwise
            transform.Rotate(Vector3.forward * (Time.deltaTime) * turnspeed);
        }

        // if the D key is pressed
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate the rocket clockwise
            transform.Rotate(-Vector3.forward * (Time.deltaTime) * turnspeed);
        }

        christanWoodRigidbody.freezeRotation = false;
    }

    private void ResetRocket()
    {
        // reset the rocket's position and rotation to where it started
        transform.position = startingPosition;
        transform.localRotation = startingRotation;

        // cancel any remaining forces on the rigidbody
        christanWoodRigidbody.velocity = Vector3.zero;
        christanWoodRigidbody.angularVelocity = Vector3.zero;
    }
}