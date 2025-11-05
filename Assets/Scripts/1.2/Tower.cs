using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        float Randomscale = Random.Range(0.5f, 10f);
        float Randompos = Random.Range(0f, 10f);
        transform.localScale = new Vector3 (Randomscale, Randomscale, Randomscale);
       transform.position = new Vector3 (Randompos, transform.position.y, Randompos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
