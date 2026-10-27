using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public EnemyFactory enemyFactory;
    public Transform[] spawnPoints;

    public int totalWaves = 5;
    public int enemiesInFirstWave = 3;
    public float timeBetweenWaves = 3f;
    public float timeBetweenSpawns = 0.5f;

    private int currentWave = 0;

    IEnumerator Start()
    {
        while (currentWave < totalWaves)
        {
            currentWave++;

            int enemyCount = enemiesInFirstWave + (currentWave - 1) * 2;

            Debug.Log("Starting Wave " + currentWave);

            // Keep track of enemies created in this wave.
            int aliveEnemies = 0;

            for (int i = 0; i < enemyCount; i++)
            {
                Transform spawnPoint = spawnPoints[i % spawnPoints.Length];

                GameObject enemy = enemyFactory.CreateEnemy(spawnPoint.position);

                if (enemy != null)
                {
                    aliveEnemies++;
                    EnemyHealth health = enemy.GetComponent<EnemyHealth>();

                    if (health != null)
                    {
                        health.OnDeath += () => aliveEnemies--;
                    }
                }

                yield return new WaitForSeconds(timeBetweenSpawns);
            }

            // Wait until every enemy from this wave is dead.
            while (aliveEnemies > 0)
            {
                yield return null;
            }

            if (currentWave < totalWaves)
            {
                yield return new WaitForSeconds(timeBetweenWaves);
            }
        }

        GameManager.Instance.WinGame();
    }
}
