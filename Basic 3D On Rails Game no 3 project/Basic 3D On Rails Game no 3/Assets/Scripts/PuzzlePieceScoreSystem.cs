using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceScoreSystem : MonoBehaviour {

    public int scoreValue = 1;

    public ScoreKeeper pinkScoreKeeper;

    void Start () {
		
	}
	
	void Update () {
		
	}

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        pinkScoreKeeper.PuzzleScore(scoreValue);
    }

}
