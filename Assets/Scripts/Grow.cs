using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale = transform.localScale + Vector3.one * _speed * Time.deltaTime;
    }
}
