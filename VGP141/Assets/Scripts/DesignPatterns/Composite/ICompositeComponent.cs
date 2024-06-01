using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP23U.DesignPatterns
{
    public interface ICompositeComponent
    {
        string Label { get; }
        Transform Transform { get; }
        void PerformAction();
        void AddComponent(ICompositeComponent component);
        void RemoveComponent(ICompositeComponent component);
        ICompositeComponent GetChild(int index);
    }
}