using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy :  EnemyController
{
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.flipX = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (sr.flipX == false)
        {
            this.GetComponent<Rigidbody2D>().velocity =new Vector2(-maxSpeed,this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity =new Vector2(maxSpeed,this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }
    
    void Update()
    {
        
    }
}
