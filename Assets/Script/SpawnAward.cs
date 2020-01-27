using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAward : MonoBehaviour
{
    public GameObject award;
    [SerializeField]
    public float cloneSpeed;
    [SerializeField]
    public float SpawnInterval;

    // Use this for initialization

    void Start()
    {
        StartSpawingAwards();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnAward_1()
    {

        GameObject clone = Instantiate(award, transform.position, transform.rotation);
        clone.GetComponent<Rigidbody2D>().velocity = new Vector3(cloneSpeed, 0);
    }
    IEnumerator SpawnAwards()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnAward_1();

            yield return new WaitForSeconds(SpawnInterval);

        }


    }

    public void StartSpawingAwards()
    {
        StartCoroutine("SpawnAwards");
    }
    public void StopSpawingAwards()
    {
        StartCoroutine("SpawnAwards");
    }
}
