using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    

    private float _playerScore;
    private float _computerScore;

    public void PlayerScores()
    {
        _playerScore++;

        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }


    public void ComputerScore()
    {
        _computerScore++;

        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
      
    }
    private void Update()
    {
        if (_playerScore > 2)
        {
            SceneManager.LoadScene(5);
        }

        if (_computerScore > 2)
        {
            SceneManager.LoadScene(4);
        }
    }
}
