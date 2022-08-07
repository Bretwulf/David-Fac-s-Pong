using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public int scoreP2 = 0;
    public Rigidbody2D ball;
    public Ball ballscript;
    public Text p2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "ball"){
            scoreP2++;
            this.p2.text = scoreP2.ToString();
            ballscript.ResetPosition();

        }
    }
}
