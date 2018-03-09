using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public Text levelScore;
    public Text totalScore;

    public static int score = 0;
    public int currentScore; // how to call this in the score display?

    void Start () {
        // Reset();
        levelScore.text = score.ToString(); // This makes the score travel to the next scene but I need it to reset when you reach the next level.

    }
	
	void Update () {
        //currentScore = score; // put this in a method & make that method the thing that is called if you click save score or if the level ends. If this isn't done the score is not saved.
       // print(currentScore);
	}

    public void Score(int points)
    {
        score += points;//adds to what it currently equals or simply increased by.
        levelScore.text = score.ToString(); //it finds the text that this script is attached to and it does something with ToString.
        print(score);
    }

    public void decreaseScore(int points)
    {
        score -= points;//adds to what it currently equals or simply increased by.
        levelScore.text = score.ToString(); //it finds the text that this script is attached to and it does something with ToString.
        print(score);
    }

    public void saveScore()
    {
        currentScore = score;
    }

    public void Reset()
    {
        score = 0;
    }

}
