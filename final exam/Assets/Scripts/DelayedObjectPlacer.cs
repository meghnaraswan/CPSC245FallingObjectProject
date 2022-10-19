using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DelayedObjectPlacer : MonoBehaviour
{
    public Camera Camera;
    protected bool isWaitingToCreate = false;

    protected float minimumTimeToNextCreation = 1f;
    protected float maximumTimeToNextCreation = 3f;

    protected float secondsUntilCreation = 0f;

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

    public void Create()
    {
        isWaitingToCreate = false;
    }
}
