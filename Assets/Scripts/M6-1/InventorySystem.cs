using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pick up : Sword = E");
        Debug.Log("Pick up : Potion = T");
        Debug.Log("Pick up : Bomb = B");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }
}
