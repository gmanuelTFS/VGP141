using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildableData", menuName = "VGP141/Data/BuildableData")]
public class BuildableData : ScriptableObject
{
    [SerializeField] private float _buildTime;
    [SerializeField] private Unit _inWorldPrefab;
    [SerializeField] private BuildableType _buildableType;

    public float BuildTime => _buildTime;
    public Unit InWorldPrefab => _inWorldPrefab;
    public BuildableType BuildableType => _buildableType;
    public BuildableCategory BuildableCategory => _buildableType.TypeToCategory();
}