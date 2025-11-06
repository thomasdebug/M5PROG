using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Towerspawner : MonoBehaviour
{
    public GameObject towerPrefab;
    void Start(){
        GameObject tower = Instantiate(towerPrefab);
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(towerPrefab);
        }
    }
}

