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

        //float randomX = Random.Range(-500, 500);

        return new Vector3(randomX,750,0);
    }
}
