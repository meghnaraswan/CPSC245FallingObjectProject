// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// where falling objects can spawn on the screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPositionTools : MonoBehaviour
{
    public static Vector3 RandomTopOfScreenWorldLocation(Camera camera)
    {
        Vector3 screenLocation = RandomTopOfScreenLocation();
        
        Debug.Log(screenLocation);
        return screenLocation;
    }

    public static Vector3 RandomTopOfScreenLocation()
    {
        float randomX = Random.Range(50, 1000);

        return new Vector3(randomX,750,0);
    }
}
