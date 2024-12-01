using UnityEngine;

public class Transfrotmation : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _gameObject;

    void Update()
    {
        if (_gameObject.CompareTag("Sphere"))
            transform.position += Vector3.forward * _speed * Time.deltaTime;

        if (_gameObject.CompareTag("Cube1"))
            transform.Rotate(Vector3.up * _speed * Time.deltaTime);

        if (_gameObject.CompareTag("Capsule"))
            transform.localScale += Vector3.one * _speed * Time.deltaTime;

        if (_gameObject.CompareTag("Cube2"))
        {
            transform.position += Vector3.forward * _speed * Time.deltaTime;
            transform.Rotate(Vector3.up * _speed * Time.deltaTime);
            transform.localScale += Vector3.one * _speed * Time.deltaTime;
        }

    }
}
