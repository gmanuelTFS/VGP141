using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP23U.DesignPatterns
{
    public abstract class MonoBehaviourSubject : MonoBehaviour
    {
        private List<IObserver> _observers;

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        protected virtual void Awake()
        {
            _observers = new List<IObserver>();
        }

        protected void NotifyObservers(string message, object data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.OnNotify(message, data);
            }
        }
    }
}