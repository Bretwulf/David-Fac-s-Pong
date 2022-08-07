using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public ScoreManager score;
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
            score.P2Scores();
        }
    }
}
