using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D; // Instace of each component

    public CircleCollider2D circleCollider;

    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
        }
        
        
    }
}
