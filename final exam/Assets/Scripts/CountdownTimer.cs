// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// timer counting down from time limit

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float timeLimit = 30;
    private GameControllerNew gameControllerNew;
    public int timerCount;

    private void Awake()
    {
        gameControllerNew = GetComponentInParent<GameControllerNew>();
    }

    private void Update()
    {
        float timeSinceGamePlayingStarted = timeLimit - Time.time;

        if (timeSinceGamePlayingStarted < 0)
        {
            //Update game state on controller to be game lost
            gameControllerNew.StateUpdate(GameControllerNew.GameStatesN.GameLost);
            //Turn off this component, disables functionality so we don't spam the GameController
            this.enabled = false;

        }

        //cast time to an int
        timerCount = (int)timeSinceGamePlayingStarted;
        Debug.Log(timerCount);
        //Update Timer text on screen
        gameControllerNew.UpdateGameTimer(timerCount);
    }
}
