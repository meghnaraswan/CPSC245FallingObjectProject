// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// Player's position in the game when moving left or right

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public void MoveRight()
    {
        transform.position += Vector3.right;
    }

    public void MoveLeft()
    {
        transform.position += Vector3.left;
    }

}
