using UnityEngine;

public class DeployEnemyShips : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;
    int randomSpawnPoint, randomShip;
    

    void Start()
    {
        InvokeRepeating("spawnEnemy", 0.1f, 2f);
        
    }

    private void spawnEnemy()
    {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        randomShip = Random.Range(0, enemies.Length);
        Instantiate(enemies[randomShip], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }
}
