using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GedeminBasesManager
{
    public class ProgressData : IObservable
    {
        private List<IObserver> observers;

        private string Value;
        public ProgressData()
        {
            observers = new List<IObserver>();
            Value = "";
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(Value);
            }
        }
        public void AddText(string text)
        {
            Value = text;
            NotifyObservers();
        }

        public bool InvokeRequired()
        {
            bool isInvokeRequired = true;
            foreach (IObserver o in observers)
            {
                isInvokeRequired = o.InvokeRequired();
            }
            return isInvokeRequired;
        }

        public void clear()
        {
            Value = "";
            foreach (IObserver o in observers)
            {
                o.clear();
            }
        }
    }
}
