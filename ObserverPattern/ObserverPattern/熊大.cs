using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class 熊大:Player,IObserverable
    {
        public 熊大()
        {
            MyTeamPartner = TeamControler.Create();
        }
    }
}
