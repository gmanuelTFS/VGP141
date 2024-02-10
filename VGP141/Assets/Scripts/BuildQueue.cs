using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildQueue : MonoBehaviour
{
    public UnitData DebugUnitData;
    public UnitData DebugUnitData2;

    private readonly Queue<BuildRequest> _buildQueue = new();

    private void Start()
    {
        AddBuildRequest(new BuildRequest(DebugUnitData));
        AddBuildRequest(new BuildRequest(DebugUnitData2));
    }

    private void Update()
    {
        if (_buildQueue.Count == 0)
        {
            return;
        }

        BuildRequest request = _buildQueue.Peek();
        request.RemainingBuildTime -= Time.deltaTime;

        Debug.Log(request);

        if (request.RemainingBuildTime < 0)
        {
            request.RemainingBuildTime = 0;
        }

        if (request.RemainingBuildTime == 0)
        {
            _buildQueue.Dequeue();
            FinalizeBuildRequest(request);
        }
    }

    public void AddBuildRequest(BuildRequest request)
    {
        _buildQueue.Enqueue(request);
        DebugLogQueue();
    }

    private void FinalizeBuildRequest(BuildRequest request)
    {
        if (request.RemainingBuildTime != 0)
        {
            return;
        }

        Instantiate(request.UnitData.View);
    }

    private void DebugLogQueue()
    {
        foreach (BuildRequest request in _buildQueue)
        {
            Debug.Log(request);
        }
    }
}
