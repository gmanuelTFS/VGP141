using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP141_22S;

public class TestBuildQueue : MonoBehaviour
{
    public BuildableData GiBuildableData;
    public BuildableData GrizzlyTankBuildableData;
    private BuildQueue _buildQueue;
    
    // Start is called before the first frame update
    void Start()
    {
        _buildQueue = new BuildQueue();
    }

    private void Update()
    {
        _buildQueue.Update(Time.deltaTime);
    }

    public void BuildGi()
    {
        _buildQueue.AddBuildRequest(new BuildRequest(GiBuildableData));
    }

    public void BuildGrizzlyTank()
    {
        _buildQueue.AddBuildRequest(new BuildRequest(GrizzlyTankBuildableData));
    }
}
