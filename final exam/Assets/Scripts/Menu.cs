using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Application.Quit();
        }

    }

    //public void LoadScene()
    //{
    //    if (Input.GetKeyDown(KeyCode.Keypad1))
    //    {
    //        SceneManager.LoadScene("SampleScene");
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
