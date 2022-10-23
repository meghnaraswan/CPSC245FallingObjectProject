using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTimer : MonoBehaviour
{
    public float timeLimit = 60;
    //private float timeGamePlayingStarted;
    private GameController gameController;

    private void Awake()
    {
        gameController = GetComponentInParent<GameController>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        //timeGamePlayingStarted = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        float timeSinceGamePlayingStarted = timeLimit - Time.time;

        if (timeSinceGamePlayingStarted < 0)
        {
            //Update game state on controller to be game lost
            gameController.StateUpdate(GameController.GameStates.GameLost);
            //Turn off this component, disables functionality so we don't spam the GameController
            this.enabled = false;
        }

        //cast time to an int
        int timerCount = (int)timeSinceGamePlayingStarted;
        //Update Timer text on screen
        gameController.UpdateGameTimer(timerCount);
    }
}
