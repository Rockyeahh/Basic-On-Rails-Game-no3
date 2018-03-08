using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScoreSystem : MonoBehaviour {

    public int scoreValue = 100;

    public ScoreKeeper redScoreKeeper;

    void Start ()
    {
        //redScoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
    }
	
	void Update () {
		
	}

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        redScoreKeeper.decreaseScore(scoreValue);
    }

  //  public void RedScore()
  //  {
  //      print("Red Score");
  //  }

  //  public void BlueScore()
  //  {
  //      print("Blue Score");
   // }

}
