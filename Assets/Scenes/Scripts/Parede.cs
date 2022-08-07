using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour
{
    public float strenght;
    public Rigidbody2D ballimp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "ball"){
            
            Vector2 normal = collision.GetContact(0).normal;
            ballimp.AddForce(-normal * this.strenght);
            Debug.Log("Bateu!");

        }
        
    }
}
