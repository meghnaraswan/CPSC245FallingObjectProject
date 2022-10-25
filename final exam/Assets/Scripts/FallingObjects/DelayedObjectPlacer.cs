// Name: Anna Wrenn
// ID: 002345622
// Email: wrenn@chapman.edu
// Course: CPSC-236-03
// Assignment: Run Corgi Run
// This is my own work and I did not cheat on this assignment.

// The purpose of this code is to place objects randomly with delays.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class DelayedObjectPlacer : ObjectPlacer
{
    public Camera Camera;
    protected bool isWaitingToCreate = false;

    protected float minimumTimeToNextCreation = 1f;
    protected float maximumTimeToNextCreation = 3f;

    protected float secondsUntilCreation = 0f;
    public SimpleTimer simpleTimer;

    void Start()
    {
        InitializeParameters();
    }

    protected virtual void InitializeParameters()
    {
        minimumTimeToNextCreation = 1f;
        maximumTimeToNextCreation = 3f;
    }

    void FixedUpdate()
    {
        if (!isWaitingToCreate)
        {
            StartWaitingToCreate();
        }

        if (simpleTimer)
        {
            
        }
    }

    private void StartWaitingToCreate()
    {
        isWaitingToCreate = true;
        secondsUntilCreation = Random.Range(minimumTimeToNextCreation, maximumTimeToNextCreation);
        StartCoroutine(CountdownUntilCreation());
    }

    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(secondsUntilCreation);
        Create();
    }

    public override void Create()
    {
        isWaitingToCreate = false;
    }
}