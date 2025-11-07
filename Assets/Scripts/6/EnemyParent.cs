using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float patrolRange = 3f;
    public int maxHealth = 3;

    private int currentHealth;
    private Vector3 startPosition;
    private int direction = 1;
    private bool isAlive = true;

    public void Start()
    {
        startPosition = transform.position;
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (isAlive)
        {
            Move();
        }
    }

    void Move()
    {
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);

        float offset = transform.position.x - startPosition.x;

        if (offset > patrolRange)
        {
            transform.position = new Vector3(startPosition.x + patrolRange, transform.position.y, transform.position.z);
            direction = -1;
        }
        else if (offset < -patrolRange)
        {
            transform.position = new Vector3(startPosition.x - patrolRange, transform.position.y, transform.position.z);
            direction = 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isAlive) return;

        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            TakeDamage(1);
        }
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isAlive = false;
        Destroy(gameObject);
    }
}
