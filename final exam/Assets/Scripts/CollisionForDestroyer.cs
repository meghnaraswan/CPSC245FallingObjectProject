// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionForDestroyer : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("CollisionForDestroyer: colliding");
    }
}
