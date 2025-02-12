using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const float DelayTime = 2f;

    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _targetPrefab;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds waitForSeconds = new(DelayTime);

        while (enabled)
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            enemy.SetTarget(_targetPrefab.transform);

            yield return waitForSeconds;
        }
    }
}
