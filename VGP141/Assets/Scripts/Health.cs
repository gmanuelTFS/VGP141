using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP23U.DesignPatterns;

namespace VGP23U
{
    public class Health : MonoBehaviourSubject
    {
        [SerializeField] private int _startingHealth;
        
        public int CurrentHealth { get; private set; }

        public void Modify(int mod)
        {
            CurrentHealth += mod;

            CurrentHealth = Mathf.Clamp(CurrentHealth, 0, _startingHealth);

            NotifyObservers(Messages.HEALTH_MODIFIED, (float)CurrentHealth / _startingHealth);

            if (CurrentHealth == 0)
            {
                NotifyObservers(Messages.HEALTH_AT_ZERO, null);
            }
        }

        protected override void Awake()
        {
            base.Awake();
            CurrentHealth = _startingHealth;
        }
    }
}