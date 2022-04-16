using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

// https://docs.microsoft.com/en-us/visualstudio/data-tools/connect-to-data-in-an-access-database-windows-forms?view=vs-2022

namespace StudentCompanion
{
    public sealed class Student 
    {
        private string _email;
        private string _first_name;
        private string _last_name;
        private bool _authenticated = false;
        private int _id;

        private Student()
        {

        }

        private static Student instance = null;
        public static Student Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Student();
                }
                return instance;
            }
        }

        public string first_name
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        public string last_name
        {
            get { return _last_name; }
            set { _last_name = value; }
        }


        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        // ReadOnly

        public bool LoggedIn => _authenticated;

        public int ID => _id;

        private int listStudents()
        {
            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "SELECT * from Students";
            connect.reader = connect.command.ExecuteReader();

            int index = 0;

            while (connect.reader.Read())
            {
                // This returns boolean for the amount of values found, therefore if it is > 1 login is true

                index = Int32.Parse(connect.reader[0].ToString()); // Get last index
            }

            connect.closeConnection();

            return index;
        
        }

        public bool login(string email, string password)
        {
            // Login Functionality

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "SELECT * from Students WHERE password = '"+ password +"' AND email = '"+ email +"' ";
            connect.reader = connect.command.ExecuteReader();

            int index = 0;

            while (connect.reader.Read())
            {
                // This returns boolean for the amount of values found, therefore if it is > 1 login is true

                index++;

                if (index == 1)
                {
                    // Login is true

                    // Get info for student

                    this._first_name = connect.reader[1].ToString();
                    this._last_name = connect.reader[2].ToString();
                    this._email = connect.reader[3].ToString();
                    this._id = Int32.Parse(connect.reader[0].ToString());
                    this._authenticated = true;

                    return true;
                }
                else
                {
                    Console.WriteLine("No Student Found");
                }
            }

            connect.closeConnection();

            return false;
        }

        private bool verifyPassword(string password, string confirm_password)
        {
    
            return false;
        }

        public void logout()
        {
            this._authenticated = false;
        }

        public bool register(string first_name, string last_name, string email, string password)
        {
            // Register by saving info on user to database https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.rowchanging?view=net-6.0

            int index = this.listStudents();

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            //(@first_name, @last_name, @email, @password, Now(), Now())


            connect.command.CommandText = "INSERT INTO Students VALUES (" + (index + 1) + ", @first_name, @last_name, @email, @password)";

            connect.command.Parameters.AddWithValue("@first_name", first_name);
            connect.command.Parameters.AddWithValue("@last_name", last_name);
            connect.command.Parameters.AddWithValue("@email", email); 
            connect.command.Parameters.AddWithValue("@password", password);

            try
            {
                if (1 == connect.command.ExecuteNonQuery())
                {
                    Console.WriteLine("Registration Successful");
                    connect.closeConnection();
                    return true;
                }

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

            
            Console.WriteLine("Issue in Registering");
            connect.closeConnection();
            return false;
        }


    }
}
