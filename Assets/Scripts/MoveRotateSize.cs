
using UnityEngine;

public class MoveRotateSize : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _speedMultiplier;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        transform.RotateAround(Vector3.up, _rotationSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_speedMultiplier, _speedMultiplier, _speedMultiplier) * Time.deltaTime;
    }
}
