using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Enemy : MonoBehaviour
{
    private Transform[] _points;
    private Movement _movement;
    private int _currentWaypointIndex = 0;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }

    private void Start()
    {
        _movement.SetTarget(_points[_currentWaypointIndex]);
    }

    private void Update()
    {
        _movement.MovementTowards();

        if (!_movement.HasReachedTarget())
        {
            _movement.SetTarget(GetNextPoint());
        }
    }

    public void GetPoints(Transform[] transform)
    {
        _points = transform;
    }

    public Transform GetNextPoint()
    {
        _currentWaypointIndex++;

        if(_currentWaypointIndex >= _points.Length)
        {
            _currentWaypointIndex = 0;
        }

        return _points[_currentWaypointIndex];
    }
}
