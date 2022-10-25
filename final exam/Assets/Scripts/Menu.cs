// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// player input at the start of the game to detemrine whether to play or quit

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("CountdownScene");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
