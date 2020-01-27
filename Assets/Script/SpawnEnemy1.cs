using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy1 : MonoBehaviour {

    public GameObject enemy1;
    [SerializeField]
    public float cloneSpeed;
    [SerializeField]
    public float SpawnInterval;

    // Use this for initialization

	void Start () {
        StartSpawingCandies();
    }
	
	// Update is called once per frame
	void Update () {
        
    
	}

    void SpawnEnemy_1()
    {

       GameObject clone =  Instantiate(enemy1, transform.position, transform.rotation);
       clone.GetComponent<Rigidbody2D>().velocity = new Vector3(cloneSpeed , 0);
    }
    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnEnemy_1();

            yield return new WaitForSeconds(SpawnInterval);

        }


    }

    public void StartSpawingCandies()
    {
        StartCoroutine("SpawnEnemies");
    }
    public void StopSpawingCandies()
    {
        StartCoroutine("SpawnEnemies");
    }
}
