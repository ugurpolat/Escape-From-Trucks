using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            GameManager.instance.IncrementScore();
        }

        else if (col.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        else if (col.gameObject.tag == "Boundary2")
        {
            Destroy(gameObject);
        }
    }
    
}
