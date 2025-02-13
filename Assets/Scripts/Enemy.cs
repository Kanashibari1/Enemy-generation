using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{   
    private Mover _mover;
    private Transform _target;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        _mover.MoveTowardsPosition(_target);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
