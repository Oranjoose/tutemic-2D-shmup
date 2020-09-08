using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    int _score = 0;
    bool _isGameOver = false;

    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _gameOverText;

    public static GameState Instance;

    void Awake() {
        Instance = this;
    }

    public void IncreaseScore(int amount) {
        _score += amount;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;
    }

    public void InititateGameOver() {
        _isGameOver = true;
        _gameOverText.SetActive(true);
    }
}
