using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _moveDirection;

    private void Update()
    {
        transform.Translate(_moveDirection * Time.deltaTime);
    }

    public void Direction(Vector3 position)
    {
        _moveDirection = position;
    }
}
