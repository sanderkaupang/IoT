using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_group3
{
    public partial class AlarmHandler : Form
    {
        public AlarmHandler()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();

            this.Hide();
        }

        private void btnAlarmDeactive_Click(object sender, EventArgs e)
        {
            picBoxDeactive.Visible = true;  // Vis PictureBox1
            picBoxActive.Visible = false; // Skjul PictureBox2
        }

        private void btnAlarmActive_Click(object sender, EventArgs e)
        {
            picBoxDeactive.Visible = false;  // Vis PictureBox1
            picBoxActive.Visible = true; // Skjul PictureBox2
        }
    }
}
