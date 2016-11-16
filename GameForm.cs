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
    public partial class GameForm : Form
    {
        
        public GameForm()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Form_startMeny newForm = new Form_startMeny();
            newForm.Show();
            this.Hide();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
