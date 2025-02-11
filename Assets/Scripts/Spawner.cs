using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const float _delayTime = 2f;

    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private Enemy _enemyPrefab;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds waitForSeconds = new(_delayTime);

        while (enabled)
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, transform.rotation);
            enemy.GetPoints(_wayPoints);

            yield return waitForSeconds;
        }
    }
}
