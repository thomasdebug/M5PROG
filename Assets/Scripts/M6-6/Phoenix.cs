using UnityEngine;

public class Phoenix : EnemyBasis
{
    private void Start()
    {
        gameObject.name = "Phoenix";
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        Debug.Log($"Phoenix Healt 10 HP! HP: {health + 10}");
        health += 10; // Phoenix geneest 10 HP bij elke aanval
        if (health <= 0)
            Die();
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Phoenix peckt {target.name} !");
    }
}
