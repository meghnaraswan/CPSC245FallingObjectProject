// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// This is where we specify the states of the player and define what each state does
// GamePlaying: player starts off in this state until player has either won or lost the game
// GameWon: outputs A+ (15/15)
// GameLost: oupts letter grade below A+

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerNew : MonoBehaviour
{
    public enum GameStatesN
    {
        GamePlaying,
        GameWon,
        GameLost
    };
    private GameViewNew gameViewNew;
    private GameStatesN gameState;
    public CountdownTimer countdownTimer;
    public Collision collision;

    // Start is called before the first frame update
    void Start()
    {
        gameViewNew = GetComponentInChildren<GameViewNew>();
        gameState = GameStatesN.GamePlaying;
    }

    private void OnGameWon()
    {
        gameState = GameStatesN.GameWon;
        // Set the text value of our result text
        gameViewNew.resultText.text = "A+ (15/15)";
        // Hide count and timer text
        gameViewNew.countText.gameObject.SetActive(false);
        gameViewNew.timerText.gameObject.SetActive(false);
        StartCoroutine(waiter());
    }

    private void OnGameLost()
    {
        gameState = GameStatesN.GameLost;
        // Set the text value of our result text
        string finalResultString = GameLostMath(collision.count);
        gameViewNew.resultText.text = finalResultString;
        // Hide count and timer text
        gameViewNew.countText.gameObject.SetActive(false);
        gameViewNew.timerText.gameObject.SetActive(false);
        StartCoroutine(waiter());
    }

    private string GameLostMath(int fallingObjectCount)
    {
        string returnString = "";
        switch (fallingObjectCount)
        {
            case 14:
                returnString = "A (14/15)";
                break;
            case 13:
                returnString = "B (13/15)";
                break;
            case 12:
                returnString = "B- (12/15)";
                break;
            case 11:
                returnString = "C (11/15)";
                break;
            case 10:
                returnString = "D (10/15)";
                break;
            case 9:
                returnString = "D- (9/15)";
                break;
            case 8:
                returnString = "F (8/15)";
                break;
            case 7:
                returnString = "F (7/15)";
                break;
            case 6:
                returnString = "F (6/15)";
                break;
            case 5:
                returnString = "F (5/15)";
                break;
            case 4:
                returnString = "F (4/15)";
                break;
            case 3:
                returnString = "F (3/15)";
                break;
            case 2:
                returnString = "F (2/15)";
                break;
            case 1:
                returnString = "F (1/15)";
                break;
            case 0:
                returnString = "F (0/15)";
                break;
            default:
                returnString = "A+ (15/15)";
                break;
        }
        return returnString;
    }

    IEnumerator waiter()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }

    public void StateUpdate(GameStatesN newState)
    {
        // Exit condition- if the game is not in play, we cannot advance to win or lose
        if (gameState != GameStatesN.GamePlaying)
        {
            return;
        }

        switch (newState)
        {
            case GameStatesN.GamePlaying:
                break;
            case GameStatesN.GameWon:
                gameState = GameStatesN.GameWon;
                OnGameWon();
                break;
            case GameStatesN.GameLost:
                gameState = GameStatesN.GameLost;
                OnGameLost();
                break;
        }
    }

    public void OnPickUpFallingObject(int playerCollectibleCount)
    {
        gameViewNew.SetCountText(playerCollectibleCount);

        // Check if our 'count' is equal to or exceeded our maxCollectibles count
        if (playerCollectibleCount >= countdownTimer.timeLimit)
        {
            StateUpdate(GameStatesN.GameWon);
        }
    }

    public void UpdateGameTimer(int timerCount)
    {
        gameViewNew.SetTimerText(timerCount);
    }
}
