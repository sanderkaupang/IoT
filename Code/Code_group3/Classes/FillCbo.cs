using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_group3.Classes
{
    internal class FillCbo
    {
        public void fillCbo(ComboBox comboBox)
        {
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
                        comboBox.Items.Add(data);
                    }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
