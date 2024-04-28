using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Utilisez cette directive si vous utilisez TextMeshPro
using UnityEngine.UI; // Assurez-vous d'inclure cette directive pour travailler avec l'UI

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Utilisez cette ligne si vous utilisez TextMeshPro
    private float score;
    private bool gameIsActive = false; // Ajoutez un booléen pour suivre l'état du jeu

    // Appelez cette méthode pour démarrer le jeu
    public void StartGame()
    {
        gameIsActive = true;
        scoreText.gameObject.SetActive(true); // Affiche le scoreText
        score = 0; // Réinitialisez le score
        UpdateScoreText();
    }

    // Appelez cette méthode pour terminer le jeu
    public void GameOver()
    {
        gameIsActive = false;
        scoreText.gameObject.SetActive(false); // Cache le scoreText
        // Vous pouvez également gérer ici d'autres logiques de fin de partie
    }
    
    void Update()
    {
        if (gameIsActive)
        {
            // Augmente le score en fonction du temps écoulé
            score += Time.deltaTime;
            UpdateScoreText();
        }
    }
  /*  public void AddScore(float amount)
    {
        // Appelée lorsqu'un collectible est récupéré
        score += amount;
        UpdateScoreText();
    }  */

    void UpdateScoreText()
    {
        // Met à jour le texte UI du score
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Mathf.FloorToInt(score);
        }
    }
}
