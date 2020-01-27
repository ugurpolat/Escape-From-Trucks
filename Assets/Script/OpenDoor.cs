using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject openDoor;
    public GameObject closeDoor;
    public GameObject vortex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            closeDoor.SetActive(false);
            openDoor.SetActive(true);
            vortex.SetActive(true);
        }
    }

}
