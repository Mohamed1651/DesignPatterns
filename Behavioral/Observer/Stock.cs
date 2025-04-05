using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Stock : IStock
    {
        private List<IObserver> _observers = new List<IObserver>();
        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Update(_price));
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
