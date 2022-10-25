// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// updating count when colling with falling object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int count;
    public GameControllerNew gameControllerNew;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        count = count + 1;

        // Run the GameController function for picking up a collectible
        gameControllerNew.OnPickUpFallingObject(count);
        Debug.Log("Collision: colliding");
    }
}
