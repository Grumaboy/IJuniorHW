using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localPosition += transform.forward * _speed * Time.deltaTime;
    }
}
