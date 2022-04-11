using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCompanion
{
    class Course
    {
        private int _id;
        private string _name;
        private string _code;
        private int _credits = 3; // Default Amount
        private string _description;
        private bool _completed;
        private string _final_grade;
        private int _semester_id; // FK

        Course()
        {

        }

        Course(int id, string name, string code, string description, int credits, bool completed, string final_grade, int semester_id)
        {

            // If loaded from database and created...

            _id = id;
            _code = code;
            _description = description;
            _completed = completed;
            _credits = credits;
            _final_grade = final_grade;
            _semester_id = semester_id;

        }

        public int id => _id;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string code
        {
            get { return _code; }
            set { _code = value; }
        }

        public int credits
        {
            get { return _credits; }
            set { _credits = credits; }
        }

        public string description
        {
            get { return _description; }
            set {_description = value; }
        }

        public bool completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        public string final_grade
        {
            get { return _final_grade; }
            set { _final_grade = value; }
        }

        public int semester_id {
            set { _semester_id = value; }
            get { return _semester_id; }
        }
        public string delete()
        {
            return "Issue Deleting This Semester";
        }

        public string save()
        {
            // Save to database

            return "Issue Saving This Course";
        }
    }
}
