using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatCollision : MonoBehaviour
{
    public GameObject gameOverPanel; 
    public scoreManager scoreManagerScript; 
    public gameManager gameManagerScript; 
     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Berge") || other.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }

   private void GameOver()
{
    Debug.Log("Game Over! Le bateau a touché un obstacle ou une berge.");

    GetComponent<playerController>().enabled = false;

    if (scoreManagerScript != null)
    {
        Debug.Log("Arrêt du score");
        scoreManagerScript.StopScore();
    }

    if (gameManagerScript != null)
    {
        Debug.Log("Configurer le panel de fin de jeu");
        gameManagerScript.SetupGameOverPanel();
    }
}

}
