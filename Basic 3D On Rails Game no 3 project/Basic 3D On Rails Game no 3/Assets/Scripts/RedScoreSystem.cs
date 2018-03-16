using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScoreSystem : MonoBehaviour {

    public int scoreValue = 100;

    public ScoreKeeper redScoreKeeper;

    void Start ()
    {
        
    }
	
	void Update () {
		
	}

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        redScoreKeeper.decreaseScore(scoreValue);
    }
}
