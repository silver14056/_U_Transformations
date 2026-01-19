using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private const float DirectionX = 0f;
    private const float DirectionY = 0f;
    private const float DirectionZ = -0.005f;

    void Update()
    {
        Vector3 movementDirection = new Vector3(DirectionX, DirectionY, DirectionZ);
        
        transform.Translate(movementDirection);

    }
}
