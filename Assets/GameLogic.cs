using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameoverscreen;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameoverscreen.SetActive(true);
    }
}
