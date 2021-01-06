using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] public Text scoreText;
    private int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Current Score: " + score);
        audioSource.Play();
    }
}
