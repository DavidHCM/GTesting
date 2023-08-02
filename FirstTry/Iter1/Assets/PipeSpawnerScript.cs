using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 10;
    private float timer = 0;
    public float heightRandom = 8;


    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime; // With deltaTime is creating a number that increments every frame
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightRandom;
        float HighestPoint = transform.position.y + heightRandom;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,HighestPoint),0), transform.rotation);
    }
}
