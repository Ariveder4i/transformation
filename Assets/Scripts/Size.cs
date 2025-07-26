using UnityEngine;

public class Size : MonoBehaviour
{
    [SerializeField] private float _speedMultiplier;

    private void Update()
    {
        transform.localScale += new Vector3 (_speedMultiplier, _speedMultiplier, _speedMultiplier) * Time.deltaTime;
    }
}
