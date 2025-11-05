using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballspawner : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;
    private float deleteTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPostion(-10f, 10f);
            CreateBall(color, randPos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Vector3 pos = new Vector3(x, y, z);
        
        deleteTime += Time.deltaTime;
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPostion(-10f, 10f);
            GameObject ball = CreateBall(randColor, pos);
            DestroyBall(ball);

            elapsedTime = 0f;
        }
    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }

    private Vector3 RandomPostion(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);
        Vector3 pos = new Vector3(x, y, z);
        return pos; 
    }

    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material mat = ball.GetComponent<MeshRenderer>().material;

        //Voor URP
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }

        return ball;
    }

    private void DestroyBall(GameObject ball)
    {
          Destroy(ball, 3); 
        
    }
}
