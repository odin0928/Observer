using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface IObserverable
    {
        void AddPlayer(IObserver observer);
        void RemovePlayer(IObserver observer);
        void Notify();
    }
}
