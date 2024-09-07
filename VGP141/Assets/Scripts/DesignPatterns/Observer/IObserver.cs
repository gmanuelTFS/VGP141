using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP23U.DesignPatterns
{
    public interface IObserver
    {
        void OnNotify(string message, object data);
    }
}