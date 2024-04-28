using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    public GameObject Panel;
    public playerController playerControllerScript;
    public scoreManager scoreManager;

    public void StartGame()
    {
        Debug.Log("StartGame is called"); // Cette ligne vous aidera à savoir si la méthode est exécutée

        if (Panel != null)
        {
            Panel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Panel reference not set in the menuManager.");
        }

        if (playerControllerScript != null)
        {
            scoreManager.StartGame();
            playerControllerScript.StartMoving();
        }
        else
        {
            Debug.LogWarning("PlayerControllerScript reference not set in the menuManager.");
        }
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame is called"); // Cette ligne vous aidera à savoir si la méthode est exécutée
        Application.Quit();
    }
}
