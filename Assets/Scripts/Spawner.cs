using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const float _delayTime = 2f;
    private const bool _enable = true;

    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private Transform[] _wayPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds waitForSeconds = new(_delayTime);

        while (_enable)
        {
            Transform spawnPoint = _spawnPoint[Random.Range(0, _spawnPoint.Length)];
            Enemy enemy = Instantiate(_enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            enemy.SetWaypoints(_wayPoints);

            yield return waitForSeconds;
        }
    }
}
