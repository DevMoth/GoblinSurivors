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
    public partial class GameOver_Form : Form
    {
        public GameOver_Form()
        {
            InitializeComponent();
            Score_text.Text = "Твой счет: " + MainForm.score.ToString();
        }
        //WOW! Such a complicated code!
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
