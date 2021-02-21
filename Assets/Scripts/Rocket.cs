using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // This is where we will list the public and private variables for the Rocket class
    
    public float thrustPower;
    
    private Rigidbody christanWoodRigidbody;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    // Start is called before the first frame update
    void Start()
    {
        // store the rocket's starting position and rotation so we can reset it if necessary
        startingPosition = transform.position;
        startingRotation = transform.localRotation;

        // get a reference to the rigidbody component attached to the rocket and store it in our christianWoodRigidbody variable
        christanWoodRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        
        // if the A key is pressed
        
            // Rotate the rocket counterclockwise
            
        // if the D key is pressed
        
            // Rotate the rocket clockwise
            
        // if the R key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetRocket();
        }
    }

    private void Thrust()
    {
        // if the space bar is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            // apply upward force to our rocket by using the "AddRelativeForce" method on it's rigidbody
            christanWoodRigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * thrustPower);
        }
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