using Code_group3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_group3
{
    public partial class ServerCon : Form
    {
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

                dgvtables.DataSource = dt;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
