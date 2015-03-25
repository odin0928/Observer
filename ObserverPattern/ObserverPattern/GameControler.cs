using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class GameControler:IObserverable
    {
        public List<IObserver> observers;
        GameEvent gamedatas;

        public TeamControler Team;
        public Player 熊大;
        public Player 兔兔;
        public Player 莎莉;
        public Player 饅頭人;


        public GameControler()
        {
            observers = new List<IObserver>();
            gamedatas = new GameEvent();

            Team = TeamControler.Create();
            熊大 = new 熊大() { Life = 10, Name = "熊大", Status = true };
            兔兔 = new 兔兔() { Life = 7, Name = "兔兔", Status = true };
            莎莉 = new 莎莉() { Life = 5, Name = "莎莉", Status = true };
            饅頭人 = new 饅頭人() { Life = 20, Name = "饅頭人", Status = true };

            AddPlayer(熊大);
            AddPlayer(兔兔);
            AddPlayer(莎莉);
            AddPlayer(饅頭人);

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
