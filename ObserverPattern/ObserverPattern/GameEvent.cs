using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class GameEvent
    {
        public string 被攻擊的對象 { get; set; }
        public int AtteckValue { get; set; }
    }
}
