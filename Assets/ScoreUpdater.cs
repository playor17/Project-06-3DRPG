using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        // Display DBallScore on the UI
        scoreText.text = "DragonBall Score: " + DBallDestroyer.DBallScore.ToString();
    }
}
