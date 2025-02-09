using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const float _delayTime = 2f;

    [SerializeField] private GameObject _unityPrefab;
    [SerializeField] private Transform[] _spawnPoint;

    private float minPosition = -15f;
    private float maxPosition = 15f;
    private Enemy _enemy;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            WaitForSeconds waitForSeconds = new(_delayTime);
            Transform spawnPoint = _spawnPoint[Random.Range(0, _spawnPoint.Length)];
            GameObject createEnemy = Instantiate(_unityPrefab, spawnPoint.position, spawnPoint.rotation);

            if (createEnemy.TryGetComponent<Enemy>(out _enemy))
            {
                Vector3 newPosition = new (Random.Range(minPosition, maxPosition), 0, Random.Range(minPosition, maxPosition));
                _enemy.Direction(newPosition);
            }

            yield return waitForSeconds;
        }
    }
}
