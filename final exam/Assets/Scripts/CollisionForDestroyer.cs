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
