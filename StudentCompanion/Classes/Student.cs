using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCompanion
{
    class Student
    {
        private string _email;
        private string _first_name;
        private string _last_name;
        private bool _authenticated = false;
        private int _id;


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

        public bool login(string email, string password)
        {
            // Login Functionality

            return false;
        }

        private bool verifyPassword(string password, string confirm_password)
        {
            return false;
        }

        public void logout()
        {
            _authenticated = false;
        }

        public bool register(string password)
        {
            // Register by saving info on user to database

            return false;
        }


    }
}
