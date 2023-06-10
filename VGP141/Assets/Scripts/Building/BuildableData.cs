using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace VGP141_22S
{
    [CreateAssetMenu(fileName = "BuildableData", menuName = "VGP141/Data/BuildableData")]
    public class BuildableData : ScriptableObject
    {
        [SerializeField] private float _buildTime;
        [SerializeField] private UnitView _inWorldPrefab;
        [SerializeField] private BuildableCategory _buildableCategory;
        [SerializeField] private List<BuildableData> _buildDependencies;

        public float BuildTime => _buildTime;
        public UnitView InWorldPrefab => _inWorldPrefab;
        public BuildableCategory BuildableCategory => _buildableCategory;
        public string PlayerFacingName => name;
        public List<BuildableData> BuildDependencies => _buildDependencies;
    }   
}