using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public int lives = 3;               // Nombre initial de vies
    public Text livesText;              // Référence au texte UI qui affiche les vies
    public Text scoreText;              // Référence au texte UI pour le score
    public GameObject gameOverPanel;    // Panel à afficher lors du Game Over
    public Image[] hearts;              // Tableau d'images pour les cœurs représentant les vies

    private int score = 0;              // Score actuel du joueur

    void Start()
    {
        UpdateLivesText();
        gameOverPanel.SetActive(false); // S'assurer que le panneau de fin de jeu est désactivé au début
    }

    public void LoseLife()
    {
        lives--;
        UpdateLivesText();
        UpdateHearts();
        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }

    // Mise à jour des cœurs dans l'UI
    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < lives)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over! Your score: " + score);
        gameOverPanel.SetActive(true); // Affiche le panneau de fin de jeu
        Time.timeScale = 0; // Arrêter le temps de jeu, peut être omis si non désiré
    }

    // Méthode pour redémarrer le jeu, peut être appelée par un bouton
    public void RestartGame()
    {
        Time.timeScale = 1; // Remettre le temps de jeu normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
