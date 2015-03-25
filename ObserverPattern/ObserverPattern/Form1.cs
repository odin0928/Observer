using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form1 : Form
    {
        GameControler Game;
        TeamControler Team;
        Player 熊大;
        Player 兔兔;
        Player 莎莉;
        Player 饅頭人;
        public Form1()
        {
            InitializeComponent();
            Game = new GameControler();
            Team = TeamControler.Create();
            熊大 = new 熊大() { Life = 10, Name = "熊大", Status = true };
            兔兔 = new 兔兔() { Life = 7, Name = "兔兔", Status = true };
            莎莉 = new 莎莉() { Life = 5, Name = "莎莉", Status = true };
            饅頭人 = new 饅頭人() { Life = 20, Name = "饅頭人", Status = true };

            Game.AddPlayer(熊大);
            Game.AddPlayer(兔兔);
            Game.AddPlayer(莎莉);
            Game.AddPlayer(饅頭人);

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            foreach (var p in Game.observers)
            {
                if (!p.Status)
                {
                    Game.RemovePlayer(p);
                    break;
                }
            }

            label兔兔生命.Text = 兔兔.Life.ToString();
            label熊大生命.Text = 熊大.Life.ToString();
            label莎莉生命.Text = 莎莉.Life.ToString();
            label饅頭人生命.Text = 饅頭人.Life.ToString();

            label兔兔狀態.Text = statusCheck(兔兔.Status);
            label熊大狀態.Text = statusCheck(熊大.Status);
            label莎莉狀態.Text = statusCheck(莎莉.Status);
            label饅頭人狀態.Text = statusCheck(饅頭人.Status);
        }

        private string statusCheck(bool status)
        {
            if (status)
            {
                return "還活著";
            }
            else
            {
                return "已陣亡";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox兔兔_Click(object sender, EventArgs e)
        {
            if (Team.TeamPartner.Contains(兔兔))
            {
                Team.RemovePlayer(兔兔);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", 兔兔.Name, Team.TeamPartner.Count);
            }
            else
            {
                Team.AddPlayer(兔兔);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", 兔兔.Name, Team.TeamPartner.Count);
            }
            

        }

        private void buttonAtteck_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (Game.observers.Count > 0)
            {
                IObserver 被攻擊的人 = Game.observers[random.Next(0, Game.observers.Count)];
                Game.Atteck(random.Next(1, 10), 被攻擊的人.Name);
                ShowMessage();
                UpdateStatus();
            }
        }

        private void ShowMessage()
        {
            this.richTextBox1.Clear();
            foreach (Player p in Game.observers)
            {
                this.richTextBox1.Text += p.SayMessage;
            }
        }

        private void pictureBox莎莉_Click(object sender, EventArgs e)
        {
            if (Team.TeamPartner.Contains(莎莉))
            {
                Team.RemovePlayer(莎莉);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", 莎莉.Name, Team.TeamPartner.Count);
            }
            else
            {
                Team.AddPlayer(莎莉);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", 莎莉.Name, Team.TeamPartner.Count);
            }
        }

        private void pictureBox熊大_Click(object sender, EventArgs e)
        {
            if (Team.TeamPartner.Contains(熊大))
            {
                Team.RemovePlayer(熊大);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", 熊大.Name, Team.TeamPartner.Count);
            }
            else
            {
                Team.AddPlayer(熊大);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", 熊大.Name, Team.TeamPartner.Count);
            }
        }

        private void pictureBox饅頭人_Click(object sender, EventArgs e)
        {
            if (Team.TeamPartner.Contains(饅頭人))
            {
                Team.RemovePlayer(饅頭人);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", 饅頭人.Name, Team.TeamPartner.Count);
            }
            else
            {
                Team.AddPlayer(饅頭人);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", 饅頭人.Name, Team.TeamPartner.Count);
            }
        }

    }
}
