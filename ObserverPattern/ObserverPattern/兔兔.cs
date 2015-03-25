using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class 兔兔:Player
    {
        public 兔兔()
        {
            MyTeamPartner = TeamControler.Create();
        }
    }
}
