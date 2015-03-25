using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class GameControler:IObserverable
    {
        public List<IObserver> observers;
        GameEvent gamedatas;
        public GameControler()
        {
            observers = new List<IObserver>();
            gamedatas = new GameEvent();
        }

        public void AddPlayer(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemovePlayer(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var p in observers)
            {
                p.SaySomething(gamedatas);
            }
        }

        public void Atteck(int AtteckValue,string Name)
        {
            gamedatas.被攻擊的對象 = Name;
            gamedatas.AtteckValue = AtteckValue;
            Notify();
        }

    }
}
