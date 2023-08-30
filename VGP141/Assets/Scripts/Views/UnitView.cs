using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class UnitView : MonoBehaviour, IObserver
    {
        private Health _health;

        private void Awake()
        {
            _health = GetComponent<Health>();

            if (_health == null)
            {
                throw new NullReferenceException("No health attached!");
            }
        }

        private void Start()
        {
            HealthBarView healthBarView = GetComponentInChildren<HealthBarView>();

            if (healthBarView == null)
            {
                throw new NullReferenceException("No health view attached!");
            }

            _health.AddObserver(healthBarView);
            _health.AddObserver(this);
        }

        public void ModifyHealth(int mod)
        {
            _health.Modify(mod);
        }

        public void OnNotify(string message, object data)
        {
            switch (message)
            {
                case Messages.HEALTH_AT_ZERO:
                    Debug.Log($"{name} - DEAD");
                    break;
                default:
                    break;
            }
        }
    }
}