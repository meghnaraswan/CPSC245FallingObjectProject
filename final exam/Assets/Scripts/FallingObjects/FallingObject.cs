// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// class for falling objects

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class FallingObject : MonoBehaviour
{
    public Image fallingObject;

    private int count;
    private GameControllerNew gameControllerNew;

    private float moveDistance = 0.1f;
    private int randomMoveCount = 0;
    private int randomDirection = 0;

    void Start()
    {
        
    }

    public void BeginMove(Vector2 direction)
    {
        Move(direction);
    }
    
    public void Move(Vector2 direction)
    {
        Vector3 amountToMove = CalculateAmountToMove(direction, moveDistance);
        fallingObject.transform.Translate(amountToMove);
        
    }

    private Vector3 CalculateAmountToMove(Vector2 direction, float moveDistance)
    {
        float amountX = direction.x * moveDistance;
        float amountY = direction.y * moveDistance;

        Vector3 amountToMove = new Vector3(amountX, amountY, 0);
        return amountToMove;
    }

    private void MoveRandomly()
    {
        int randomDirection = ChooseRandomDirection();
        MoveOneDirection(randomDirection);
        randomMoveCount--;
    }

    private void MoveOneDirection(int direction)
    {
        switch (direction)
        {
            case 0:
                Move(new Vector2(0, 1));
                break;
            case 1:
                Move(new Vector2(0, -1));
                break;
            case 2:
                Move(new Vector2(1, 0));
                break;
            case 3:
                Move(new Vector2(-1, 0));
                break;
        }
    }

    private int ChooseRandomDirection()
    {
        if (randomMoveCount == 0)
        {
            int direction = Random.Range(0, 4);
            randomMoveCount = 15;
        }
        return randomDirection;
    }

    private Vector3 ReverseControlInput(Vector3 amountToMove)
    {
        amountToMove.x = -1 * amountToMove.x;
        amountToMove.y = -1 * amountToMove.y;

        return amountToMove;
    }
    
}
