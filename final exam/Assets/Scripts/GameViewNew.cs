// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// define the countText, resultText, and timerText when in game view

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameViewNew : MonoBehaviour
{
    public Text countText;
    public Text resultText;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        // Set the text property of our Result Text UI to an empty string, making the game over message blank
        resultText.text = "";
        countText.text = "0";
    }

    // Create a standalone function that can update the 'countText' UI and check if the required amount to win has been achieved
    public void SetCountText(int count)
    {
        // Update the text field of our 'countText' variable
        countText.text = count.ToString();
    }

    public void SetTimerText(int count)
    {
        timerText.text = count.ToString();
    }
}
