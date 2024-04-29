using UnityEngine;
using TMPro; 
using UnityEngine.UI;
public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    public TextMeshProUGUI scoreCollectible;
    public float score;
    public float scoreCoin;
    public int coinsCollected = 0;
    private bool gameIsActive = false;

    public void StartGame()
    {
        gameIsActive = true;
        scoreText.gameObject.SetActive(true);
        score = 0;
         if (scoreCollectible != null)
        scoreCollectible.gameObject.SetActive(true);
    else
        Debug.LogError("scoreCollectible n'est pas assigné dans le scoreManager.");

        scoreCoin = 0;
        UpdateScoreText();
    }

    public void GameOver()
    {
        gameIsActive = false;
        scoreText.gameObject.SetActive(false);
        scoreCollectible.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (gameIsActive)
        {
            score += Time.deltaTime;
            UpdateScoreText();
        }
    }
    public void AddCoin()
    {
        coinsCollected++;
        UpdateCoinsText();
    }

    private void UpdateCoinsText()
    {
        if (scoreCollectible != null)
        {
            scoreCollectible.text = "Coins: " + coinsCollected;
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Mathf.FloorToInt(score);
        }
    }
    public void StopScore()
    {
        gameIsActive = false;
    }

    public float GetCurrentScore()
    {
        return score;
    }
}
