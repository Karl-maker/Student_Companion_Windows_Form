using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCompanion
{
    class Note
    {
        private int _id;
        private int _course_id;
        private string _title;
        private string _description;
        private DateTime _created_at = new DateTime();

        Note()
        {

        }

        Note(int id, int course_id, string title, string description, DateTime created_at)
        {
            _id = id;
            _course_id = course_id;
            _title = title;
            _description = description;
            _created_at = created_at;
        }

        public int id => _id;

        public int course_id
        {
            get { return _course_id; }
            set { _course_id = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime created_at => _created_at;

        public string delete()
        {
            return "Issue In Deleting Note";
        }

        public string save()
        {
            // set created_at and send to database
            return "Issue In Saving Note";
        }
    }
}
