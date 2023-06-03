using System.Collections.Generic;

namespace VGP141_22S.DesignPatterns
{
    public class Subject
    {
        private readonly HashSet<IObserver> _observers = new();
        private readonly HashSet<IObserver> _observersToRemove = new();

        public void AddObserver(IObserver pObserver)
        {
            _observers.Add(pObserver);
        }

        public void RemoveObserver(IObserver pObserver)
        {
            _observersToRemove.Add(pObserver);
        }

        protected void NotifyObservers(string notification)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Notify(notification);
            }

            RemoveQueuedObservers();
        }
        
        protected void NotifyObservers<T>(string notification, T data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Notify(notification, data);
            }

            RemoveQueuedObservers();
        }

        private void RemoveQueuedObservers()
        {
            foreach (IObserver observer in _observersToRemove)
            {
                _observers.Remove(observer);
            }
        }
    }   
}
