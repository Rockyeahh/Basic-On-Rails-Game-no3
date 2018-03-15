using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public int speed;

	void Start () {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
	
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        //print("Collison");
        speed = 0;
    }

}
