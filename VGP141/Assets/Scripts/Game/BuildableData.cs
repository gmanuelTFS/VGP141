using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Data
{
    [CreateAssetMenu(fileName = "NewBuildableData", menuName = "Data/BuildableData", order = 0)]
    public class BuildableData : ScriptableObject
    {
        [SerializeField] private UnitType _unitType;
        [SerializeField] private float _buildTime;
        [SerializeField] private BuildableView _viewPrefab;

        public UnitType UnitType => _unitType;
        public float BuildTime => _buildTime;
        public BuildableView ViewPrefab => _viewPrefab;
    }
}