using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

    public int speed;

    void Start () {

    }
	
	void Update () {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);
    }
}
