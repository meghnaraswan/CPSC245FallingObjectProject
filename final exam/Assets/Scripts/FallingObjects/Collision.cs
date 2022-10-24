using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private int count;
    public GameControllerNew gameControllerNew;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        count = count + 1;

        // Run the GameController function for picking up a collectible
        //gameControllerNew = new GameControllerNew();
        gameControllerNew.OnPickUpFallingObject(count);
        Debug.Log("Collision: colliding");
    }
}
