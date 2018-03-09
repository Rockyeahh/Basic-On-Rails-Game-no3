using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text levelScore;
    public Text totalScore;
    //public Text puzzleScore;
    public ScoreKeeper scoreKeeperScript;

    //private ScoreKeeper currentScore;
    //public int currentScore;

	void Start () {
        levelScore = GetComponent<Text>();
        //currentScore = GameObject.Find("Score").GetComponent<ScoreKeeper>(); // Doesnt work. Not set to an instance of an object.

                                    // Put the currentScore call here.
    }
	
	void Update () {
		
	}

    public void DisplayUpdate() // Maybe it needs to be changed to LateUpdate.
    {
        levelScore.text = GameObject.Find("currentScore").GetComponent<ScoreKeeper>().ToString(); // This should instead of score say something that checks the scorekeeper for the current static int score.
    }

}
