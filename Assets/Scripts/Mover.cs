using UnityEngine;

public class Mover : MonoBehaviour
{
    private const float Threshold = 0.1f;

    public void MovementTowards(Transform position, float speed)
    {
        transform.LookAt(position.position);
        transform.position = Vector3.MoveTowards(transform.position, position.position, speed * Time.deltaTime);
    }

    public bool HasReachedTarget(Transform position)
    {
        return (position.position - transform.position).sqrMagnitude > Threshold * Threshold;
    }
}
