using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_group3.Classes
{
    internal class FillDgv
    {
        public void fillDgvM(DataGridView dataGridView)
        {
            string sqlQuery2 = @"SELECT * from Alarm ORDER BY alarmId DESC";
            try
            {
                SQLcon classConnection = new SQLcon();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery2, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void FillDgvAcknowledge(ComboBox comboBox, DataGridView dataGridView)
        {
            string sqlQuery3 = @"AlarmList";
            string alarmId;
            alarmId = comboBox.Text;

            SQLcon classConnection = new SQLcon();
            classConnection.ConnectionToDatabase();
            SqlCommand sql;
            sql = new SqlCommand("alarmKvittert", SQLcon.myCon);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add(new SqlParameter("alarmId", alarmId));
            sql.ExecuteNonQuery();
            comboBox.Items.Clear();


            using (SqlCommand command = new SqlCommand(sqlQuery3, SQLcon.myCon))
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    string data = reader["alarmId"].ToString();
                    // Legg data til i ComboBox
                    comboBox.Items.Add(data);
                }

            string sqlQuery4 = @"SELECT * from AlarmKvittert1 ORDER BY alarmId DESC";
            try
            {

                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery4, SQLcon.myCon);
                dt = new DataTable();
                sda.Fill(dt);

                dataGridView.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
