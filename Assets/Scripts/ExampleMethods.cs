using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMethods : MonoBehaviour
{
    public int shotsAttempted;
    public int shotsMade;
    
    private void Start()
    {
        print("You are shooting " + ShowThreePointPercentage(shotsAttempted, shotsMade));
    }

    // this shows three point percentage
    private float ShowThreePointPercentage(int attempted, int made)
    {
        float percentage = (float) made / attempted;

        return percentage;
    }
}