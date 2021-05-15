using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver { get; private set; }
    public static bool isLevelComplete { get; private set; }

    private void Awake()
    {
        isGameOver = false;
        isLevelComplete = false;
    }

    private void Update()
    {
        if (isLevelComplete)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextLevel();
            }
        }
        else if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RetryGame();
            }
        }
    }

    public static void GameOver()
    {
        isGameOver = true;
    }

    public static void CompleteLevel()
    {
        isLevelComplete = true;
    }

    public static void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
