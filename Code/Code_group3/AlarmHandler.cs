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
            /////////////////////////////////
            string sqlQuery2 = @"AlarmList"; 
            try
            {

                SQLcon classConnection = new SQLcon();
                classConnection.ConnectionToDatabase();

                using (SqlCommand command = new SqlCommand(sqlQuery2, SQLcon.myCon))
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string data = reader["alarmId"].ToString();
                        // Legg data til i ComboBox
                        cboAlarmId.Items.Add(data);
                    }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


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

            string sqlQuery5 = @"select * from AlarmKvittert1";

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

            string sqlQuery2 = @"SELECT * from Alarm";
            try
            {
                SQLcon classConnection = new SQLcon();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery2, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dgvAlarmActive.Rows.Clear();
                dgvAlarmActive.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery3 = @"AlarmList";
            string alarmId;
            alarmId = cboAlarmId.Text;

            SQLcon classConnection = new SQLcon();
            classConnection.ConnectionToDatabase();
            SqlCommand sql;
            sql = new SqlCommand("alarmKvittert", SQLcon.myCon);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add(new SqlParameter("alarmId", alarmId));
            sql.ExecuteNonQuery();
            cboAlarmId.Items.Clear();


            using (SqlCommand command = new SqlCommand(sqlQuery3, SQLcon.myCon))
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    string data = reader["alarmId"].ToString();
                    // Legg data til i ComboBox
                    cboAlarmId.Items.Add(data);
                }
            
            string sqlQuery4 = @"SELECT * from Alarm";
            try
            {
                
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery4, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);

                dgvAlarmActive.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
