using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private Transform[] _spawnPoints;
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var numberEnemy = 0;
        var waitTwoSeconds = new WaitForSeconds(2f);
        while (true)
        {
            var enemyPosition = numberEnemy % 3;
            var createdEnemy = Instantiate(_template, _spawnPoints[enemyPosition].position, Quaternion.identity);
            numberEnemy++;
            yield return waitTwoSeconds;
        }
    }
}
