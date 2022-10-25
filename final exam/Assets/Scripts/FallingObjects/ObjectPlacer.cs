// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// The purpose of this code is to place down different objects.

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPlacer : MonoBehaviour
{
    public GameObject Prefab;

    public virtual void Create(Vector3 position)
    {
        GameObject newObject = Instantiate(Prefab, position, Quaternion.identity);

    }

    public virtual void Create()
    {

    }
}
