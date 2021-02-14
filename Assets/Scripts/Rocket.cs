using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // This is where we will list the public and private variables for the Rocket class
    
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    public float thrustPower;
    private Rigidbody christanWoodRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // store the rocket's starting position and rotation so we can reset it if necessary
        startingPosition = transform.position;
        startingRotation = transform.localRotation;
        christanWoodRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("thrust");
            christanWoodRigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * thrustPower);
        }
    }
    
    private void ResetRocket()
    {
      
    }
}
