using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goblin_Survivors
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        MainForm GameWindow = new MainForm();
        List<int> hiscorelist = new List<int>() { 1000000, 700300, 404500, 100900, 50000, 47900, 22500, 15300, 10000, 5300 };
        List<int> hilevellist = new List<int>() { 20, 18, 16, 14, 12, 10, 8, 6, 4, 2 };
        bool score_shown = false;

        //Starting the game and updating the scoreboard after losing
        private void GameStart_button_Click(object sender, EventArgs e)
        {
            GameWindow.ShowDialog();
            GameOver_Form GameOver = new GameOver_Form();
            GameOver.ShowDialog();
            for (int i = 0; i < 10; ++i)
            {
                if (hiscorelist[i] < MainForm.score)
                {
                    hiscorelist.Insert(i, MainForm.score);
                    hilevellist[i] = MainForm.level;
                    hiscorelist.RemoveAt(10);
                    break;
                }
            }
            ScoreBoard.Items.Clear();
            for (int i = 0; i < 10; ++i)
            {
                ScoreBoard.Items.Add((i + 1).ToString() + ". " + hiscorelist[i].ToString() + " очков | " + hilevellist[i] + " уровень");
            }

        }

        //showing and hiding the scoreboard
        private void Score_button_Click(object sender, EventArgs e)
        {
            score_shown = !score_shown;
            if (score_shown)
            {
                this.Height = 560;
            }
            else
            {
                this.Height = 400;
            }
        }

        //filling the scoreboard in on startup
        private void MainMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                ScoreBoard.Items.Add((i + 1).ToString() + ". " + hiscorelist[i].ToString() + " очков | " + hilevellist[i] + " уровень");
            }
        }
    }
}
