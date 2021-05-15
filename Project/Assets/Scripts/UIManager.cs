using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text enemyProgressText;
    public Image playerHealthBar;
    public float playerHealthBarFullX = 78;

    public GameObject gameOverUI;
    public GameObject levelCompleteUI;

    public PlayerController player;

    void Update()
    {
        if (enemyProgressText)
        {
            enemyProgressText.text = ScoreManager.currentEnemyProgress + " of " + ScoreManager.targetEnemyProgress;
        }

        if (playerHealthBar)
        {
            Vector2 size = playerHealthBar.rectTransform.sizeDelta;
            size.x = player.health / player.healthMax * playerHealthBarFullX;

            playerHealthBar.rectTransform.sizeDelta = size;
        }

        if (levelCompleteUI && GameManager.isLevelComplete)
        {
            levelCompleteUI.SetActive(GameManager.isLevelComplete);
        } else if (gameOverUI && GameManager.isGameOver)
        {
            gameOverUI.SetActive(GameManager.isGameOver);
        }
    }
}
