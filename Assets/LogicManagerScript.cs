using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicManagerScript : MonoBehaviour
{
    private int playerScore = 0;
    public TMP_Text scoreText;

    public void AddScore() {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
