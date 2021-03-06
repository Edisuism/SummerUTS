﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Health healthDisplay;
    [SerializeField] private PlayerController player;
    [SerializeField] private Text gameOverText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] public Text scoreText;
    private int score;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void DamagePlayer()
    {
        //reduce the player's health by 1 
        player.health--;
        //if we have an audio source then play it
        if (audioSource)
        {
            audioSource.Play();
        }
        Debug.Log("damage");
        //call the deduct health method from health display and pass it's return to isGameOver
        isGameOver = healthDisplay.DeductHealth();

        if (isGameOver)
        {
            gameOverText.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Current Score: " + score);
        audioSource.Play();
    }
}
