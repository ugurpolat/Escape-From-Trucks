using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    bool canMove = false;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float maxPosX;

    float maxPosY = 4.4f;
    float minPosY = -8.55f;

    public GameObject bar;
    int time = 30;

    // Use this for initialization
    void Start()
    {
        OpenLock();
    }

    // Update is called once per frame
    void Update()
    {

        if (canMove)
        {
            Move();

        }
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;


    }
    private void Move()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
        transform.position += Vector3.up * inputY * moveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -maxPosX, maxPosX);
        float yPos = Mathf.Clamp(transform.position.y, minPosY, maxPosY);

        transform.position = new Vector3(xPos, yPos);


    }

    IEnumerator Lock()
    {
        yield return new WaitForSeconds(3f);
        AnimateBar();
        canMove = true;
    }

    public void OpenLock()
    {
        StartCoroutine("Lock");
        
    }
    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 0.5f, time).setOnComplete(ShowMessage);
    }

    void ShowMessage()
    {
        GameManager.instance.gameOverPanel.SetActive(true);
        gameObject.SetActive(false);
    }
}