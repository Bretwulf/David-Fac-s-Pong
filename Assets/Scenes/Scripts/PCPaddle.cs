using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCPaddle : MonoBehaviour
{
    public Rigidbody2D ballpos;
    public Rigidbody2D padmov;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ballpos.velocity.x > 0.0f){
            if (ballpos.position.y > this.transform.position.y){
                padmov.AddForce(Vector2.up * this.speed);
            }
            else if(ballpos.position.y < this.transform.position.y){
                padmov.AddForce(Vector2.down * this.speed);
            }
        }
        else{
           if (this.transform.position.y > 0.0f){
            padmov.AddForce(Vector2.down*this.speed);
           }
           else if (this.transform.position.y < 0.0f){
            padmov.AddForce(Vector2.up*this.speed);
           }
        }

        
    }
}
