using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    private const float Speed = 6f;

    void Update()
    {
        Vector3 forwardDirection = transform.forward;

        Vector3 movement = forwardDirection * Speed * Time.deltaTime;

        transform.position += movement;
    }
}
