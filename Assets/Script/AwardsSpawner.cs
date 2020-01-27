using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardsSpawner : MonoBehaviour {

    [SerializeField]
    float maxY;

    public GameObject[] awards;

    [SerializeField]
    public float cloneSpeed;

    [SerializeField]
    float SpawnInterval;

    //public static AwardsSpawner instance;
    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //}

    // Use this for initialization
    void Start () {

        StarSpawingAwards();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnAward()
    {
        int rand = Random.Range(0, awards.Length);

        float randomY = Random.Range(-maxY, maxY);

        Vector3 randomPos = new Vector3(transform.position.x, randomY,transform.position.z);

        GameObject clone = Instantiate(awards[rand], randomPos, transform.rotation);
        clone.GetComponent<Rigidbody2D>().velocity = new Vector3(cloneSpeed, 0);
    }

    IEnumerator SpawnAwards()
    {
        yield return new WaitForSeconds(6f);
        while (true)
        {
            SpawnAward();
            yield return new WaitForSeconds(SpawnInterval);
        }
    }

    public void StarSpawingAwards()
    {
        StartCoroutine("SpawnAwards");
    }
    public void StopSpawingAwards()
    {
        StopCoroutine("SpawnAwards");
    }
}
