using UnityEngine;
using VGP141_22S;

[CreateAssetMenu(fileName = "BuildableCategory", menuName = "VGP141/Data/BuildableCategory")]
public class BuildableCategory : ScriptableObject
{
    [SerializeField] private bool _isBuilding;

    public bool IsBuilding => _isBuilding;
}
