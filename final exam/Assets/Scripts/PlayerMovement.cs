using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private float xMin, xMax;
    //private float yMin, yMax;

    //void Start()
    //{
    //    var spriteSize = GetComponent<SpriteRenderer>().bounds.size.x * .5f; // Working with a simple box here, adapt to you necessity

    //    var cam = Camera.main;// Camera component to get their size, if this change in runtime make sure to update values
    //    var camHeight = cam.orthographicSize;
    //    var camWidth = cam.orthographicSize * cam.aspect;

    //    yMin = -camHeight + spriteSize; // lower bound
    //    yMax = camHeight - spriteSize; // upper bound

    //    xMin = -camWidth + spriteSize; // left bound
    //    xMax = camWidth - spriteSize; // right bound 
    //}

    //void Update()
    //{
        
    //}

    public void MoveRight()
    {
        transform.position += Vector3.right;
    }

    public void MoveLeft()
    {
        transform.position += Vector3.left;
    }

}
