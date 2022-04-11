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
        private DateTime _start_date = new DateTime();
        private DateTime _end_date = new DateTime();

        Semester()
        {
            // This will be used for creating a new Semester
        }

        Semester(int id, DateTime start_date, DateTime end_date )
        {
            // Load semester id from Database and update all attributes
            _id = id;
            _start_date = start_date;
            _end_date = end_date;
        }

        public int id => _id;

        public float gpa => _gpa; 

        public int credits
        {
            get
            {
                // Get total credits database from courses
                return _credits;
            }
        
        }

        public DateTime start_date
        {
            get { return _start_date; }
            set {  
                // Check if DateTime
                _start_date = value; 
            }
        }

        public DateTime end_date
        {
            get { return _end_date; }
            set
            {
                // Check if DateTime
                _end_date = value;
            }
        }

        public void calculateGPA()
        {
            // Get all courses from database and calculate GPA then update it
        }

        public string delete()
        {
            return "Issue Deleting This Semester";
        }

        public string save()
        {
            // Save semester in database

            return "Issue Saving This Semester";
        }

    }
}
