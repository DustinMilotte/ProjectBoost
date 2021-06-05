using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionOscillator : MonoBehaviour
{
    [SerializeField] private Vector3 movementDirection;
    [SerializeField] private float timeForCycle = 2f;

    private Vector3 startingPosition;
    private float movementFactor;

    void Start()
    {
        startingPosition = transform.position; // store the object's starting position in a variable
    }

    void Update()
    {
        float cycles = Time.time / timeForCycle; // this keeps track of where you are in the cycle

        const float tau = Mathf.PI * 2; // constant value of 6.283
        float rawSinWave = Mathf.Sin(cycles * tau); // going from -1 to 1

        movementFactor = (rawSinWave + 1f) / 2f; // recalculated to go from 0 to 1 so its cleaner

        Vector3 offset = movementDirection * movementFactor; // calculate how much to move this frame
        transform.position = startingPosition + offset; // move the object 
    }
}