using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnitData", menuName = "Data/Units/UnitData")]
public class UnitData : ScriptableObject
{
    [SerializeField] private float _baseBuildTime;
    [SerializeField] private UnitView _view;
}
