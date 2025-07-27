using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
    }
}
