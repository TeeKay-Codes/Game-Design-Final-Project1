using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject slimePrefab;

    public GameObject CreateEnemy(Vector3 spawnPosition)
    {
        GameObject newEnemy = Instantiate(slimePrefab);
        newEnemy.transform.position = spawnPosition;

        newEnemy.SetActive(true);

        return newEnemy;
    }
}
