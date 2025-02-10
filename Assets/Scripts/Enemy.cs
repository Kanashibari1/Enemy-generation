using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform[] _wayPoints;
    private int _currentWaypointIndex;
    private int _speed = 5;

    private void Update()
    {
        Transform targetWayPoints = _wayPoints[_currentWaypointIndex];
        transform.LookAt(targetWayPoints.position);
        transform.position = Vector3.MoveTowards(transform.position, targetWayPoints.position, _speed * Time.deltaTime);
    }

    public void SetWaypoints(Transform[] wayPoints)
    {
        _wayPoints = wayPoints;
        _currentWaypointIndex = Random.Range(0, _wayPoints.Length);
    }
}
