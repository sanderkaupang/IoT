using Code_group3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            TimerAlarmACtive.Enabled = true;
            FillCbo fillCbo = new FillCbo();
            fillCbo.fillCbo(cboAlarmId);  

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

            string sqlQuery5 = @"select * from AlarmKvittert1 ORDER BY alarmId DESC";

            try
            {
                SQLcon classConnection = new SQLcon();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery5, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                
                dgvKvittert.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



        }


        private void btnAlarmActive_Click(object sender, EventArgs e)
        {
            picBoxDeactive.Visible = false;  // Vis PictureBox1
            picBoxActive.Visible = true; // Skjul PictureBox2

            FillDgv fillDgv = new FillDgv();
            fillDgv.fillDgvM(dgvAlarmActive);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDgv fillDgv = new FillDgv();
            fillDgv.FillDgvAcknowledge(cboAlarmId, dgvKvittert);
            fillDgv.fillDgvM(dgvAlarmActive);

            cboAlarmId.Text = "";
        }

        private void dgvAlarmActive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimerAlarmACtive_Tick(object sender, EventArgs e)
        {
            FillDgv fillDgv = new FillDgv();
            fillDgv.fillDgvM(dgvAlarmActive);
        }
    }
}
