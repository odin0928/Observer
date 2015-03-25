using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        string Name { get; set; }
        int Life { get; set; }
        bool Status { get; set; }
        string SayMessage { get; set; }
        void SaySomething(GameEvent gamedata);
        void ReciveHelp(IObserver SayHelper);
    }
}
