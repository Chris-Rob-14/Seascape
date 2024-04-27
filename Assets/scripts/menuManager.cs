using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    public void StartGame()
    {
        //Test
        SceneManager.LoadScene("GameScene");  // Assurez-vous que le nom de la scène est correct
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
