// Name: Anna Wrenn and Meghna Raswan
// ID: 002345622 and 002337415
// Email: wrenn@chapman.edu and raswan@chapman.edu
// Course: CPSC-245-01
// Assignment: Exam 1

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
    public CountdownTimer countdownTimer;
    public float objectsToSpawn;

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
        if (!isWaitingToCreate && (countdownTimer.timerCount > 0))
        {
            StartWaitingToCreate();
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