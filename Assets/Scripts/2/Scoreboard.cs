using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private int score = 0;

    private void OnEnable()
    {
        Pickup.OnPickupCollected += AddScore;
    }
    private void OnDisable()
    {
        Pickup.OnPickupCollected -= AddScore;
    }
    private void Start()
    {
        UpdateScoreText();
    }
    private void AddScore()
    {
        score += 50;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
