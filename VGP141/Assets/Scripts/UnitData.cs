using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnitData", menuName = "Data/Units/UnitData")]
public class UnitData : ScriptableObject
{
    [SerializeField] private float _baseBuildTime;
    [SerializeField] private UnitView _view;

    public float BaseBuildTime => _baseBuildTime;
    public UnitView View => _view;

    public override string ToString()
    {
        return $"{nameof(BaseBuildTime)}: {BaseBuildTime}, {nameof(View)}: {View.name}";
    }
}
