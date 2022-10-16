using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    
    private bool _isPlayerDead;
    private int _score;

    private void OnEnable()
    {
        EventManager.OnPlayerDeath += OnPlayerDeath;
        EventManager.UpdateScore += UpdateScore;
    }
    
    private void OnDisable()
    {
        EventManager.OnPlayerDeath -= OnPlayerDeath;
        EventManager.UpdateScore -= UpdateScore;
    }

    private void UpdateScore()
    {
        if (_isPlayerDead) return;
        _score++;
        scoreText.text = "Score: " + _score;
    }

    private void OnPlayerDeath()
    {
        _isPlayerDead = true;
    }
}
