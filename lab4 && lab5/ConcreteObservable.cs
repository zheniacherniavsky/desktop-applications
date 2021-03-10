using System.Collections.Generic;

namespace lab2
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers(string state = null);
    }

    class ConcreteObservable : IObservable
    {
        private List<IObserver> list;

        public ConcreteObservable()
        {
            list = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            list.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            list.Remove(o);
        }

        public void NotifyObservers(string state = null)
        {
            foreach (IObserver observer in list)
            {
                observer.Update(state);
            }
        }
    }

    interface IObserver
    {
        void Update(string state);
    }
}
