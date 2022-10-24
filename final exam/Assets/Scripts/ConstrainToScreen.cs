using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConstrainToScreen : MonoBehaviour
{

    void LateUpdate()
    {
        Vector2 objectPosition = transform.position;
        objectPosition.x = Mathf.Clamp(objectPosition.x, 0, 1000);
        objectPosition.y = Mathf.Clamp(objectPosition.y, -381, 420);
        transform.position = objectPosition;
    }
}
