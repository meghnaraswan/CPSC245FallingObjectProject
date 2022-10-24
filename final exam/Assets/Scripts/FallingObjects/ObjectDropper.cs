// Name: Anna Wrenn
// ID: 002345622
// Email: wrenn@chapman.edu
// Course: CPSC-236-03
// Assignment: Run Corgi Run
// This is my own work and I did not cheat on this assignment.

// The purpose of this code is to randomly generate moonshine.

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
        GameObject moonshine = Instantiate(Prefab, ScreenPositionTools.RandomTopOfScreenWorldLocation(Camera), Quaternion.identity, GameObject.FindGameObjectWithTag("Panel").transform);
    }
}