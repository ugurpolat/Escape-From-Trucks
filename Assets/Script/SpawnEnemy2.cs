using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy2 : MonoBehaviour {

    public GameObject enemy2;

    [SerializeField]
    public float cloneSpeed;

    [SerializeField]
    public float SpawnInterval;

	// Use this for initialization
	void Start () {
        StartSpawingEnemies();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnEnemy_2()
    {
        GameObject clone = Instantiate(enemy2,transform.position,transform.rotation);
        clone.GetComponent<Rigidbody2D>().velocity = new Vector3(-cloneSpeed, 0);
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnEnemy_2();

            yield return new WaitForSeconds(SpawnInterval);
        }

    }

    public void StartSpawingEnemies()
    {
        StartCoroutine("SpawnEnemies");

    }
    public void StopSpawingEnemies()
    {
        StopCoroutine("SpawnEnemies");
    }

}
