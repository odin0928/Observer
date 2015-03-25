using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class 饅頭人:Player
    {
        public 饅頭人()
        {
            MyTeamPartner = TeamControler.Create();
        }
    }
}
