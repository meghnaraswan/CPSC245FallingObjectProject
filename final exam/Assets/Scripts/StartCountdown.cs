// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// timer counting down from 3 using coroutine

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartCountdown : MonoBehaviour
{
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown(3));
    }

    IEnumerator Countdown(int seconds)
    {
        int count = seconds;

        while (count > 0)
        {

            // display something...
            timerText.text = count.ToString();
            yield return new WaitForSeconds(1);
            count--;
        }
        timerText.text = "GO!";

        yield return new WaitForSeconds(2);
        // count down is finished...
        StartGame();
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
