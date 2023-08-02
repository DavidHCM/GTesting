using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;

    public Text scoreText;

    [ContextMenu("Increase Score of Player")]
    public void addScore(int scoretoAdd)
    {
        playerScore += scoretoAdd;
        scoreText.text = playerScore.ToString();
    }
}
