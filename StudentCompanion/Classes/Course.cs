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
        private int _student_id;
        private string _description;
        private bool _completed;
        private string _final_grade;
        private int _semester_id; // FK

        Course()
        {

        }

        Course(int id, string name, string code, string description, int credits, bool completed, string final_grade, int semester_id, int student_id)
        {

            // If loaded from database and created...

            _id = id;
            _code = code;
            _name = name;
            _description = description;
            _completed = completed;
            _credits = credits;
            _final_grade = final_grade;
            _student_id = student_id;
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

        public int student_id
        {
            set { _student_id = value; }
            get { return _student_id; }
        }

        public bool delete()
        {

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "DELETE FROM Courses WHERE 'Course ID' = " + this._id + " ";
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
            // Save to database

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "INSERT INTO Courses ('" + this._name + "', '" + this._code + "', '" + this._description + "', '" + this._completed + "', '" + this._final_grade + "', '" + this._credits + "', '" + this._student_id + "', '" + this._semester_id + "')";
            if (1 == connect.command.ExecuteNonQuery())
            {
                Console.WriteLine("Save Successful");
                connect.closeConnection();
                return true;
            }

            Console.WriteLine("Issue in Saving");
            connect.closeConnection();
            return false;
        }
    }
}
