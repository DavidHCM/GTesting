using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D; // Instace of each component
    public float flapStrength;
    public LogicScript logic;


    public bool BirdAlive;

    // Start is called before the first frame update
    void Start()
    {

        BirdAlive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W) && BirdAlive)
        {
           myRigidbody2D.velocity = Vector2.up * flapStrength;
        }
 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        BirdAlive = false;  
        
    }
}
