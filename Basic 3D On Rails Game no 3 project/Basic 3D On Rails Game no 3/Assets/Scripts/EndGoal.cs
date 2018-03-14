using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGoal : MonoBehaviour {

    public GameObject ScoreScreen;

    void Awake()
    {
        // Screen Screen On disable?
    }

    void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        // Make UI score screen button on enable.
        ScoreScreen.SetActive(true);
    }

}
