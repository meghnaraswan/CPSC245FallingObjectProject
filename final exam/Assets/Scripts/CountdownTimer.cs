using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float timeLimit = 15;
    private GameControllerNew gameControllerNew;

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
        int timerCount = (int)timeSinceGamePlayingStarted;
        //Update Timer text on screen
        gameControllerNew.UpdateGameTimer(timerCount);
    }
}
