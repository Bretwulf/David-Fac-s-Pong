using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int scoreP1=0, scoreP2=0;
    public Text p1,p2;
    public Ball ball;
    public P1Paddle paddle1;
    public P2Paddle paddle2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void P1Scores(){
        scoreP1++;
        this.p1.text = scoreP1.ToString();
        ball.ResetPosition();
        paddle1.ResetPosition();
        paddle2.ResetPosition();

    }
    public void P2Scores(){
        scoreP2++;
        this.p2.text = scoreP2.ToString();
        ball.ResetPosition();
        paddle1.ResetPosition();
        paddle2.ResetPosition();

    }

}
