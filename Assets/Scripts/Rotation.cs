
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.RotateAround(Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
