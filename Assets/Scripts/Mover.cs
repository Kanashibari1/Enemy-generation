using UnityEngine;

public class Mover : MonoBehaviour
{
    private const float Threshold = 0.1f;

    [SerializeField] private float _speed;

    public void MoveTowardsPosition(Transform position)
    {
        transform.LookAt(position.position);
        transform.position = Vector3.MoveTowards(transform.position, position.position, _speed * Time.deltaTime);
    }

    public bool HasReachedTarget(Transform position)
    {
        return (position.position - transform.position).sqrMagnitude > Threshold * Threshold;
    }
}
