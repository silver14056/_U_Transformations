using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(transform.forward * _speed);
    }
}
