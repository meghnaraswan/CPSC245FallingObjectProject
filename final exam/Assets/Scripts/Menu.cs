using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Keypad1))
    //    {
    //        SceneManager.LoadScene("CountdownScene");
    //    }
    //    if (Input.GetKeyDown(KeyCode.Keypad2))
    //    {
    //        Application.Quit();
    //    }

    //}

    //public void LoadScene()
    //{
    //    SceneManager.LoadScene("CountdownScene");
    //}
    //public void QuitScene()
    //{
    //    Application.Quit();
    //}

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

    //public void LoadScene()
    //{
    //    if (Input.GetKeyDown(KeyCode.Keypad1))
    //    {
    //        SceneManager.LoadScene("CountdownScene");
    //    }
    //}
    //public void Quit()
    //{
    //    if (Input.GetKeyDown(KeyCode.Keypad2))
    //    {
    //        Application.Quit();
    //    }
    //}
}
