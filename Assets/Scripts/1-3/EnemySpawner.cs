using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> enemies = new List<GameObject>();

    public float spawninterval = 1f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawninterval)
        {
            SpawnEnemies(3);
            timer = 0f;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnEnemies(100);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }
    }

    private void SpawnEnemies(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 spawnPos = transform.position + new Vector3(Random.Range(-2f, 2f), 0, Random.Range(-2f, 2f));
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
            enemies.Add(newEnemy);
        }
    }

    private void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
                Destroy(enemy);
        }
        enemies.Clear();

    }
}
