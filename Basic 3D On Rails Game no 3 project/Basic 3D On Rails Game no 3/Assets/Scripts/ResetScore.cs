using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour {

    public ScoreKeeper resetScoreKeeper;



    void Awake()
    {
        
    }

    void Start () {

        ScoreKeeper myInstance = resetScoreKeeper.GetComponent<ScoreKeeper> (); // Not set to an instance of an object? This error occurs if the scorekeeper and reset score are active in the main menu.
        myInstance.Reset();
    }
	
	void Update () {
		
	}

}
