using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

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

            Destroy(col.gameObject);
            // Destroy(gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
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
    void OnCollisionEnter2D(Collision2D collin)
    {
        if (collin.gameObject.tag == "Player")
        {
            GameManager.instance.gameOverPanel.SetActive(true);
            Destroy(collin.gameObject);
            Destroy(gameObject);
        }
    }

}
