using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCompanion
{
    class Semester
    {

        private int _id;
        private float _gpa;
        private int _credits;
        private int _student_id;
        private DateTime _start_date = new DateTime();
        private DateTime _end_date = new DateTime();

        Semester()
        {
            // This will be used for creating a new Semester
        }

        Semester(int id, int student_id, DateTime start_date, DateTime end_date )
        {
            // Load semester id from Database and update all attributes
            _id = id;
            _start_date = start_date;
            _end_date = end_date;
            _student_id = student_id;
        }

        public int id => this._id;

        public int student_id
        {
            get
            {
                return this._student_id;
            }
            set
            {
                // Check if DateTime
                this._student_id = value;
            }
        }

        public float gpa => this._gpa; 

        public int credits
        {
            get
            {
                // Get total credits database from courses
                return this._credits;
            }
        
        }

        public DateTime start_date
        {
            get { return this._start_date; }
            set {  
                // Check if DateTime
                this._start_date = value; 
            }
        }

        public DateTime end_date
        {
            get { return this._end_date; }
            set
            {
                // Check if DateTime
                this._end_date = value;
            }
        }

        public void calculateGPA()
        {
            // Get all courses from database and calculate GPA then update it

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "SELECT * from Courses WHERE 'Semester ID' = '" + this._id + "' ";
            connect.reader = connect.command.ExecuteReader();

            int index = 0;

            while (connect.reader.Read())
            {
                // This returns boolean for the amount of values found, therefore if it is > 1 login is true

                index++;

                if (index > 0)
                {
                    // Login is true

                    // Get info for student

                    if ("" != connect.reader[5].ToString() || " " != connect.reader[5].ToString())
                    {
                        // Add to GPA




                    }

                   
                }
                else
                {
                    Console.WriteLine("No Courses Found");
                    this._gpa = 0;
                }
            }

            connect.closeConnection();

  
        }

        public bool delete()
        {
            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "DELETE FROM Semesters WHERE 'Semester ID' = " + this._id + " ";
            if (1 == connect.command.ExecuteNonQuery())
            {
                Console.WriteLine("Deleted Successful");
                connect.closeConnection();
                return true;
            }

            Console.WriteLine("Issue Deleting");
            connect.closeConnection();
            return false;
        }

        public bool save()
        {
            // Save semester in database

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "INSERT INTO Semesters ('" + this._student_id + "', '" + this._start_date + "', '" + this._end_date + "', '" + this._gpa + "')";
            if (1 == connect.command.ExecuteNonQuery())
            {
                Console.WriteLine("Deleted Successful");
                connect.closeConnection();
                return true;
            }

            Console.WriteLine("Issue Deleting");
            connect.closeConnection();
            return false;
        }

    }
}
