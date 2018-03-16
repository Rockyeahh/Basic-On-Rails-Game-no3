using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScoreSystem : MonoBehaviour {

    public int scoreValue = 100;

    public ScoreKeeper blueScoreKeeper;

    void Start()
    {
       
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        blueScoreKeeper.Score(scoreValue);
    }
}
