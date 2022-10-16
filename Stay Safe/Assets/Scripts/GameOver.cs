using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        [SerializeField] Button restartButton;

        private void OnEnable()
        {
            EventManager.OnPlayerDeath += ShowGameOverPanel;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerDeath -= ShowGameOverPanel;
        }

        private void Start()
        {
            restartButton.onClick.RemoveAllListeners();
            restartButton.onClick.AddListener(Restart);
        }

        private void ShowGameOverPanel()
        {
            gameOverPanel.SetActive(true);
        }

        private void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }