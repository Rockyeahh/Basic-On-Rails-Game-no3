using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public static int score = 0;
    public int currentScore; // how to call this in the score display?

    void Start () {
       // Reset();
    }
	
	void Update () {
        currentScore = score;
	}

    public void Score(int points)
    {
        score += points;//adds to what it currently equals or simply increased by.
        //myText.text = score.ToString(); //it finds the text that this script is attached to and it does something with ToString.
        print(score);
    }

    public void decreaseScore(int points)
    {
        score -= points;//adds to what it currently equals or simply increased by.
        //myText.text = score.ToString(); //it finds the text that this script is attached to and it does something with ToString.
        print(score);
    }

    public static void Reset()
    {
        score = 0;
    }

}
