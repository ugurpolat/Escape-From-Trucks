using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VortexScript : MonoBehaviour {

    float speedRotate = 50f;

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {

        transform.Rotate(-Vector3.forward * speedRotate * Time.deltaTime);
	}

    


   
}
