using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        // Pas eigenschappen aan voor een trage, sterke Brute
        moveSpeed = 1f;
        patrolRange = 2f;
        maxHealth = 10;

        // Startpositie en health resetten net als in parent
        base.Start();
    }
}
