using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D physics;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        AddStartingForce();
    }

    public void AddStartingForce(){
        float x = Random.value < 0.5f ? -1.0f: 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f):Random.Range(1.0f, 0.5f);
        physics.AddForce(new Vector2(x,y)*this.speed);

    }
    public void ResetPosition(){
        physics.position = Vector2.zero;
        physics.velocity = Vector2.zero;
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
