using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Player:IObserver,IObserverable
    {
        public TeamControler MyTeamPartner;
        public string Name { get; set; }
        public int Life { get; set; }
        public bool Status { get; set; }
        public string SayMessage { get; set; }
        public void SaySomething(GameEvent gamedata)
        {
            string teampartenrName = string.Empty;
            SayMessage = string.Empty;
            if (gamedata.被攻擊的對象.Equals(this.Name))
            {
                this.Life -= gamedata.AtteckValue;
                if (this.Life < 0) this.Life = 0;
                CheckMyStatus();

                if (gamedata.AtteckValue > 0)
                {
                    if (MyTeamPartner.TeamPartner.Count > 1)
                    {
                        foreach (var t in MyTeamPartner.TeamPartner)
                        {
                            if (!t.Name.Equals(this.Name))
                            {
                                if (teampartenrName.Equals(string.Empty))
                                {
                                    if (!t.Name.Equals(this.Name))
                                        teampartenrName += t.Name;
                                }
                                else
                                {
                                    teampartenrName += "," + t.Name;
                                }
                            }
                        }
                        SayMessage = string.Format("{0}被攻擊了，生命力剩下{1}，"+ teampartenrName + " 快來救我\n", this.Name, this.Life);
                    }
                    else
                    {
                        SayMessage = string.Format("{0}沒有隊友，好慘，生命力剩下{1}\n", this.Name, this.Life);
                    }
                }
            }
        }
        public void ReciveHelp(IObserver SayHelper)
        {
            if ((MyTeamPartner.TeamPartner.Contains(SayHelper)) && (MyTeamPartner.TeamPartner.Contains(this)))
            {
                SayMessage = string.Format("我是{0}，我去幫助隊友{1}\n", this.Name, SayHelper.Name);
            }
        }
        protected void CheckMyStatus()
        {
            if (Life <= 0)
            {
                Status = false;
            }
        }

        public void AddPlayer(IObserver observer)
        {
            MyTeamPartner.TeamPartner.Add(observer);
        }

        public void RemovePlayer(IObserver observer)
        {
            MyTeamPartner.TeamPartner.Remove(observer);
        }

        public void Notify()
        {
            foreach (var t in MyTeamPartner.TeamPartner)
            {
                t.ReciveHelp(this);
            }
        }
    }
}
