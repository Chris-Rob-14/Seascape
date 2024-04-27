using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
 public Text scoreText;
    private int score = 0;

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Méthode pour gérer la pause
    public void TogglePause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;  // Pause
        }
        else
        {
            Time.timeScale = 1;  // Reprise
        }
    }
}
