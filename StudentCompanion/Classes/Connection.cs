using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace StudentCompanion
{
    class Connection
    {
        public OleDbConnection connection = new OleDbConnection();
        public OleDbCommand command = new OleDbCommand();
        public OleDbDataReader reader;

        private const string DB_LOCATION = @"C:\Users\offic\Documents\USC Projects\StudentCompanion\StudentCompanion\StudentCompanion\Documentation\DB\StudentCompanion.accdb";


        public Connection()
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DB_LOCATION + ";Persist Security Info=False;";
                connection.Open();

            }
            catch (Exception error)
            {
                throw error;
            }

        }

        public void openConnection()
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DB_LOCATION + ";Persist Security Info=False;";
                connection.Open();

            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void closeConnection()
        {
            try
            {
               connection.Close();

            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
