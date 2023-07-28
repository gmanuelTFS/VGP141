using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace VGP23U
{
    [CreateAssetMenu(menuName = "23U/BuildableData", fileName = "BuildableData")]
    public class BuildableData : ScriptableObject
    {
        public enum Type
        {
            AttackDog,
            GrizzlyTank,
        }

        public float BuildTime => _buildTime;
        public BuildableView BuildableView => _buildableView;
        public Type BuildableType => _buildableType;
        public string PlayerFacingName => _playerFacingName;
        public int Cost => _cost;

        [SerializeField] private float _buildTime;
        [SerializeField] private BuildableView _buildableView;
        [SerializeField] private Type _buildableType;
        [SerializeField] private string _playerFacingName;
        [Min(0), SerializeField, Tooltip("Not currently used.")] private int _cost;
    }
}