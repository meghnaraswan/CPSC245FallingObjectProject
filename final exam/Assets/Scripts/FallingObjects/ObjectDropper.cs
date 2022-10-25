// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

// The purpose of this code is to randomly generate falling objects

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ObjectDropper : DelayedObjectPlacer
{
    protected override void InitializeParameters()
    {
        minimumTimeToNextCreation = 1f;
        maximumTimeToNextCreation = 1f;
    }

    public override void Create()
    {
        base.Create();
        GameObject fallingObjects = Instantiate(Prefab, ScreenPositionTools.RandomTopOfScreenWorldLocation(Camera), Quaternion.identity, GameObject.FindGameObjectWithTag("Panel").transform);
    }
}