using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Paddle : MonoBehaviour
{
    public Rigidbody2D physics;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            physics.AddForce(Vector2.up * this.speed);
            
        }
        if(Input.GetKey(KeyCode.DownArrow)){
           physics.AddForce(Vector2.down * this.speed);
        }
    }

    public void ResetPosition(){
        physics.position = new Vector2(physics.position.x, 0);
    }
}
