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
    //private int maxCollectiblesCount;

    // Start is called before the first frame update
    void Start()
    {
        gameViewNew = GetComponentInChildren<GameViewNew>();
        gameState = GameStatesN.GamePlaying;
        //maxCollectiblesCount = GameObject.FindGameObjectsWithTag("FallingObject").Length;
    }

    private void OnGameWon()
    {
        gameState = GameStatesN.GameWon;
        // Set the text value of our result text
        //gameViewNew.resultText.text = "You Win!";
        //Hide count and timer text
        gameViewNew.countText.gameObject.SetActive(false);
        gameViewNew.timerText.gameObject.SetActive(false);
        //Time.timeScale = 0; //should pause scene
        StartCoroutine(waiter());
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnGameLost()
    {
        gameState = GameStatesN.GameLost;
        // Set the text value of our result text
        //gameViewNew.resultText.text = "You Lose.";
        //Hide count and timer text
        gameViewNew.countText.gameObject.SetActive(false);
        gameViewNew.timerText.gameObject.SetActive(false);
        //Time.timeScale = 0; //should pause scene
        StartCoroutine(waiter());
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator waiter()
    {
        //Wait for 5 seconds
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Menu");
    }

    public void StateUpdate(GameStatesN newState)
    {
        //Exit condition- if the game is not in play, we cannot advance to win or lose
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

        //Check if our 'count' is equal to or exceeded our maxCollectibles count
        //if (playerCollectibleCount >= maxCollectiblesCount)
        //{
        //    StateUpdate(GameStatesN.GameWon);
        //}
    }

    public void UpdateGameTimer(int timerCount)
    {
        gameViewNew.SetTimerText(timerCount);
    }
}
