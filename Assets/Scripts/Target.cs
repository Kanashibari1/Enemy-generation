using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Target : MonoBehaviour
{
    [SerializeField] private int _speed = 5;

    [SerializeField] private Transform[] _wayPoint;

    private Mover _move;
    private int _currentWaypointIndex = 0;

    private void Awake()
    {
        _move = GetComponent<Mover>();
    }

    private void Update()
    {
        _move.MovementTowards(_wayPoint[_currentWaypointIndex], _speed);

        if (_move.HasReachedTarget(_wayPoint[_currentWaypointIndex]) == false)
        {
            GetNextPoint();
        }
    }

    private void GetNextPoint()
    {
        _currentWaypointIndex = ++_currentWaypointIndex % _wayPoint.Length;
    }
}
