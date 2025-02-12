using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    private const float Speed = 2.5f;

    private Mover _move;
    private Transform _target;

    private void Awake()
    {
        _move = GetComponent<Mover>();
    }

    private void Update()
    {
        _move.MovementTowards(_target, Speed);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
