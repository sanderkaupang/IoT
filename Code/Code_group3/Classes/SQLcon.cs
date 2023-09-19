using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_group3.Classes
{
    internal class SQLcon
    {
        public static SqlConnection myCon = null;
        public SqlCommand cmd;


        public void ConnectionToDatabase()
        {       //connect to database with the connection string under. 
            myCon = new SqlConnection("Server=tcp:sqldatabaseusn.database.windows.net,1433;Initial Catalog=sqlDB;Persist Security Info=False;User ID=sander;Password=Sommer2023;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            myCon.Open();
        }
    }
}
