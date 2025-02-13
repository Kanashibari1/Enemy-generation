using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoint;

    private Mover _move;
    private int _currentWaypointIndex = 0;

    private void Awake()
    {
        _move = GetComponent<Mover>();
    }

    private void Update()
    {
        _move.MoveTowardsPosition(_wayPoint[_currentWaypointIndex]);

        if (_move.HasReachedTarget(_wayPoint[_currentWaypointIndex]) == false)
        {
            ChooseNextPoint();
        }
    }

    private void ChooseNextPoint()
    {
        _currentWaypointIndex = ++_currentWaypointIndex % _wayPoint.Length;
    }
}
