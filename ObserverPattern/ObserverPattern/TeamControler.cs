using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class TeamControler
    {
        public List<IObserver> TeamPartner;

        static TeamControler Team1;
        static public TeamControler Create()
        {
            if (Team1 == null)
            {
                return Team1 = new TeamControler();
            }
            return Team1;
        }

        public TeamControler()
        {
            TeamPartner = new List<IObserver>();
        }

        public void AddPlayer(IObserver observer)
        {
            TeamPartner.Add(observer);
        }

        public void RemovePlayer(IObserver observer)
        {
            TeamPartner.Remove(observer);
        }
    }
}
