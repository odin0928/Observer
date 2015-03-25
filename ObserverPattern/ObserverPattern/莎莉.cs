using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class 莎莉:Player
    {
        public 莎莉()
        {
            MyTeamPartner = TeamControler.Create();
        }
    }
}
