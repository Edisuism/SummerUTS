using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Health healthDisplay;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private PlayerController player;
    [SerializeField] private Text gameOverText;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamagePlayer()
    {
        player.health--;
        Debug.Log("damage");
        isGameOver = healthDisplay.DeductHealth();

        if (isGameOver)
        {
            gameOverText.gameObject.SetActive(true);
            scoreManager.scoreText.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
