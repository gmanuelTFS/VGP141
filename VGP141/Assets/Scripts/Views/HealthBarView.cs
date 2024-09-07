using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class HealthBarView : MonoBehaviour, IObserver
    {
        [SerializeField] private Slider _slider;

        public void OnNotify(string message, object data)
        {
            switch (message)
            {
                case Messages.HEALTH_MODIFIED when data is float value:
                    _slider.value = value;
                    break;
                default:
                    break;
            }
        }
    }
}