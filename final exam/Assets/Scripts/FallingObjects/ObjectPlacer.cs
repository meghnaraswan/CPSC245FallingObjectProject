// Name: Anna Wrenn
// ID: 002345622
// Email: wrenn@chapman.edu
// Course: CPSC-236-03
// Assignment: Run Corgi Run
// This is my own work and I did not cheat on this assignment.

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
