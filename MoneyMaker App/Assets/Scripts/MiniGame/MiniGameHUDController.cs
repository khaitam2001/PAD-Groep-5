﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MiniGameHUDController : MonoBehaviour
{

    public Text ScoreText, GameOverScoreText, TimerText;
    public float MaxTime = 20;
    public GameObject GameOverPanel;

    private int score;
    private float time;

    void Start()
    {
        ScoreText.text = "Score: 0";
    }

    void Update()
    {

        time += Time.deltaTime;

        var remainingTime = MaxTime - Mathf.Floor(time);
        TimerText.text = "Time: " + remainingTime;

        //pauses all objects when the time hits 0
        if (remainingTime == 0)
        {
            FindObjectOfType<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GameOverPanel.SetActive(true);
            GameOverScoreText.text = "Your Score: " + score;

            time = MaxTime;
        }
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //adds score
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;

        ScoreText.text = "Score: " + score;
    }

    public void Restart()
    {
        SceneManager.LoadScene("MiniGame");
    }

}
