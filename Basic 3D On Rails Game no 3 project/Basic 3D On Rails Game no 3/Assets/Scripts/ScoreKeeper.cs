using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public Text levelScore;
    public Text highScore;
    public Text puzzleGained;
    public Text puzzleTotal;

    public static int score = 0;
    public static int puzzleScore = 0;
    public int currentScore; // how to call this in the score display?
    public int currentPuzzleScore;

    void Start () {
        // Reset();
        levelScore.text = score.ToString(); // This makes the score travel to the next scene but I need it to reset when you reach the next level.
        puzzleGained.text = puzzleScore.ToString();
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

    public void PuzzleScore(int points)
    {
        puzzleScore += points;
        puzzleGained.text = puzzleScore.ToString(); // Not set to an instance of an object in level 1 because there is nowhere for it to be set to string.
        //puzzleTotal + puzzleGained.text = puzzleScore.ToString(); // How do I make it so that the puzzle total adds the puzzle gained onto itself.
        print(score);
    }

    public void saveScore()
    {
        currentScore = score;
    }

    public void savePuzzleScore()
    {
        currentPuzzleScore = puzzleScore;
    }

    public void Reset()
    {
        score = 0;
        puzzleScore = 0;
    }

}
