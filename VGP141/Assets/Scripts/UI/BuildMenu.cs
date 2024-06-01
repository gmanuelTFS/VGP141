using System;
using System.Collections.Generic;
using Game;
using UnityEngine;
using Game.Data;

namespace UI
{
    public class BuildMenu : MonoBehaviour
    {
        [SerializeField] private BuildableCountTracker _buildableCountTracker;
        [SerializeField] private BuildQueue _buildQueue;
        [SerializeField] private BuildMenuButton _buildMenuButtonPrefab;
        
        private readonly List<BuildableData> _buildables = new();

        private void Awake()
        {
            _buildables.AddRange(Resources.LoadAll<BuildableData>("BuildableData/Buildings"));
            _buildables.AddRange(Resources.LoadAll<BuildableData>("BuildableData/Infantry"));
            _buildables.AddRange(Resources.LoadAll<BuildableData>("BuildableData/Vehicles"));
        }

        private void Start()
        {
            foreach (BuildableData buildableData in _buildables)
            {
                BuildMenuButton buildMenuButton = Instantiate(_buildMenuButtonPrefab, transform);
                buildMenuButton.Initialize(_buildQueue, buildableData);
                buildMenuButton.gameObject.SetActive(_buildableCountTracker.CanBeBuilt(buildableData));
            }
        }
    }
}
