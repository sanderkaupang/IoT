using Code_group3.Classes;
using Microsoft.Azure.Devices.Client;
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
using System.Web.Configuration;
using System.Windows.Forms;

namespace Code_group3
{
    public partial class ServerCon : Form
    {
        public string BtnMsg = "Åpen";

        public ServerCon()
        {
            InitializeComponent();



        }



        private void btnCheckTables_Click(object sender, EventArgs e)
        {
            string sqlQuery2 = @"SELECT * from Car";
            try
            {
                SQLcon classConnection = new SQLcon();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery2, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dgvtables.Rows.Clear();
                dgvtables.DataSource = dt;


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

            //Mota knapp signal
            //Task<MethodResponse> BtnPush(MethodRequest methodRequest, object userContext)
            //{

            //    try
            //    {
            //        if (true)
            //        {
            //            dgvtables.Rows.Add(BtnMsg);
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //    return null;
            //}


        }


        private void dgvtables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBtn_Click(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn kolonne = new DataGridViewTextBoxColumn();
            kolonne.HeaderText = "Melding";
            dgvtables.Columns.Add(kolonne);

            dgvtables.Rows.Add(BtnMsg);
            dgvtables.Rows.Clear();
        }
    }
}
