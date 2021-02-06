using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // This is where we will list the public and private variables for the Rocket class
    
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        // store the rocket's starting position and rotation so we can reset it if necessary
        startingPosition = transform.position;
        startingRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void ResetRocket()
    {
      
    }
}
