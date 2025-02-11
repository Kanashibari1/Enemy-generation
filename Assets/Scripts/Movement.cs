using UnityEngine;

public class Movement : MonoBehaviour
{
    private int _speed = 5;
    private float threshold = 0.1f;
    private Transform targetWayPoints;

    public void SetTarget(Transform wayPoints)
    {
        targetWayPoints = wayPoints;
    }

    public void MovementTowards()
    {
        transform.LookAt(targetWayPoints.position);
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoints.position, _speed * Time.deltaTime);
    }

    public bool HasReachedTarget()
    {
        return Vector3.Distance(transform.position, targetWayPoints.position) > threshold;
    }
}
