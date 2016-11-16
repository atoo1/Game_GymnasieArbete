using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spelet123
{
    public partial class Form_startMeny : Form
    {
        public Form_startMeny()
        {
            InitializeComponent();
        }

        GameForm newForm = new GameForm();

        private void pBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_startMeny_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            timer1.Start();
            panel_difficulty.Hide();
        }

        private void pBox_Start_Click(object sender, EventArgs e)
        {
            panel_difficulty.Show();
            panel_StartMenu.Hide();
        }

        private void pBox_Easy_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        }

        private void pBox_Medium_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        }

        private void pBox_Hard_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();
        }

        private void pBox_Hardcore_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 0.95)
            {
                Opacity = 1;
                timer1.Stop();
            }
            else
            {
                Opacity += 0.05;
            }
        }

        private void panel_difficulty_Paint(object sender, PaintEventArgs e)
        {
            Opacity = 0;
            timer1.Start();
        }
    }
}
