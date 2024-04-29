using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro; 

public class gameManager : MonoBehaviour
{
    public scoreManager scoreManagerScript; 
   public TextMeshProUGUI scoreText; 
   public GameObject gameOverPanel;

    public void SetupGameOverPanel()
    {
        if (scoreManagerScript != null && scoreText != null)
        {
            float finalScore = scoreManagerScript.GetCurrentScore();
            scoreText.text = "Score final : " + finalScore;
        }
        gameOverPanel.SetActive(true);
    }
   
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
