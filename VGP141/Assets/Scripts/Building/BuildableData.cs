using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP141_22S
{
    [CreateAssetMenu(fileName = "BuildableData", menuName = "VGP141/Data/BuildableData")]
    public class BuildableData : ScriptableObject
    {
        [SerializeField] private float _buildTime;
        [SerializeField] private UnitView _inWorldPrefab;
        [SerializeField] private BuildableType _buildableType;

        public float BuildTime => _buildTime;
        public UnitView InWorldPrefab => _inWorldPrefab;
        public BuildableType BuildableType => _buildableType;
        public BuildableCategory BuildableCategory => _buildableType.TypeToCategory();
        public string PlayerFacingName => _buildableType.ToString("G");
    }   
}