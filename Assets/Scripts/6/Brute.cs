using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        
        moveSpeed = 1f;
        patrolRange = 2f;
        maxHealth = 10;

        
        base.Start();
    }
}
