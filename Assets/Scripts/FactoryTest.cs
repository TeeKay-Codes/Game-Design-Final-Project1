using UnityEngine;

public class FactoryTest : MonoBehaviour
{
    public EnemyFactory enemyFactory;

    private void Start()
    {
        enemyFactory.CreateEnemy(new Vector3(6, 1, 5));
        enemyFactory.CreateEnemy(new Vector3(.5f, 1, 5));
        enemyFactory.CreateEnemy(new Vector3(3, 1, 5));
    }
}
