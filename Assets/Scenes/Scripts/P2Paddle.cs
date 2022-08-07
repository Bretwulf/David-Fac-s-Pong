using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Paddle : Paddle
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            this.physics.AddForce(Vector2.up * this.speed);
            
        }
        if(Input.GetKey(KeyCode.DownArrow)){
           this.physics.AddForce(Vector2.down * this.speed);
        }
    }

    public void ResetPosition(){
        this.physics.position = new Vector2(this.physics.position.x, 0);
    }
}
