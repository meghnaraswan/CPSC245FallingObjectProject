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
        float randomX = Random.Range(-356, 378);

        return new Vector3(randomX,300,0);
    }
}
