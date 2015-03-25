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

        public Form1()
        {
            InitializeComponent();
            Game = new GameControler();


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

            label兔兔生命.Text = Game.兔兔.Life.ToString();
            label熊大生命.Text = Game.熊大.Life.ToString();
            label莎莉生命.Text = Game.莎莉.Life.ToString();
            label饅頭人生命.Text = Game.饅頭人.Life.ToString();

            label兔兔狀態.Text = statusCheck(Game.兔兔.Status);
            label熊大狀態.Text = statusCheck(Game.熊大.Status);
            label莎莉狀態.Text = statusCheck(Game.莎莉.Status);
            label饅頭人狀態.Text = statusCheck(Game.饅頭人.Status);
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
            if (Game.Team.TeamPartner.Contains(Game.兔兔))
            {
                Game.Team.RemovePlayer(Game.兔兔);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", Game.兔兔.Name, Game.Team.TeamPartner.Count);
            }
            else
            {
                Game.Team.AddPlayer(Game.兔兔);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", Game.兔兔.Name, Game.Team.TeamPartner.Count);
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
            if (Game.Team.TeamPartner.Contains(Game.莎莉))
            {
                Game.Team.RemovePlayer(Game.莎莉);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", Game.莎莉.Name, Game.Team.TeamPartner.Count);
            }
            else
            {
                Game.Team.AddPlayer(Game.莎莉);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", Game.莎莉.Name, Game.Team.TeamPartner.Count);
            }
        }

        private void pictureBox熊大_Click(object sender, EventArgs e)
        {
            if (Game.Team.TeamPartner.Contains(Game.熊大))
            {
                Game.Team.RemovePlayer(Game.熊大);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", Game.熊大.Name, Game.Team.TeamPartner.Count);
            }
            else
            {
                Game.Team.AddPlayer(Game.熊大);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", Game.熊大.Name, Game.Team.TeamPartner.Count);
            }
        }

        private void pictureBox饅頭人_Click(object sender, EventArgs e)
        {
            if (Game.Team.TeamPartner.Contains(Game.饅頭人))
            {
                Game.Team.RemovePlayer(Game.饅頭人);
                richTextBox1.Text += string.Format("玩家{0}離開組隊，目前隊伍中共有{1}人\n", Game.饅頭人.Name, Game.Team.TeamPartner.Count);
            }
            else
            {
                Game.Team.AddPlayer(Game.饅頭人);
                richTextBox1.Text += string.Format("玩家{0}加入隊伍，目前隊伍中共有{1}人\n", Game.饅頭人.Name, Game.Team.TeamPartner.Count);
            }
        }

    }
}
