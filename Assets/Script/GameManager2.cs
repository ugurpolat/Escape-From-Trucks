﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameObject gameOverPanel;
    public static GameManager2 instance;

    int score = 0;
    bool gameOver = false;
    public Text scoreText;
    

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void IncrementScore()
    {
        if (!gameOver)
        {
            score += 100;
            scoreText.text = score.ToString();
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Exit()
    {
        

    }

    
}