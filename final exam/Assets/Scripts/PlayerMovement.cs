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
