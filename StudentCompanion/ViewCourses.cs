using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCompanion
{   
    public partial class ViewCourses : Form
    {

        Student student = Student.Instance;
        List<Course> CourseList = new List<Course>();
        int active_index = 0;

        public ViewCourses() // Also one with semester id
        {
            InitializeComponent();

            // Add All Items To ComboBox

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "SELECT * from Courses WHERE StudentID = " + student.ID + "";
            connect.reader = connect.command.ExecuteReader();

            while (connect.reader.Read())
            {
                // Add list to combobox and create list of semesters...

                // Paralle Arrays will help with selection

                CourseList.Add(new Course(Int32.Parse(connect.reader[0].ToString()), connect.reader[1].ToString(), connect.reader[2].ToString(), connect.reader[3].ToString(), Int32.Parse(connect.reader[7].ToString()), false, connect.reader[4].ToString(), Int32.Parse(connect.reader[5].ToString()), Int32.Parse(connect.reader[6].ToString())));
                courseList.Items.Add(connect.reader[1].ToString());


            }

            connect.closeConnection();
        }
        public ViewCourses(int semester_id) // Also one with semester id
        {
            InitializeComponent();

            // Add All Items To ComboBox

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "SELECT * from Courses WHERE StudentID = " + student.ID + " AND SemesterID = " + semester_id + "";
            connect.reader = connect.command.ExecuteReader();

            while (connect.reader.Read())
            {
                // Add list to combobox and create list of semesters...

                // Paralle Arrays will help with selection

                CourseList.Add(new Course(Int32.Parse(connect.reader[0].ToString()), connect.reader[1].ToString(), connect.reader[2].ToString(), connect.reader[3].ToString(), Int32.Parse(connect.reader[7].ToString()), false, connect.reader[4].ToString(), Int32.Parse(connect.reader[5].ToString()), Int32.Parse(connect.reader[6].ToString())));
                courseList.Items.Add(connect.reader[1].ToString());


            }

            connect.closeConnection();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void semesterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            active_index = courseList.SelectedIndex;

            creditsLabel.Text = CourseList[active_index].credits.ToString();
            nameLabel.Text = CourseList[active_index].name.ToString();
            codeLabel.Text = CourseList[active_index].code.ToString();
            descriptionLabel.Text = CourseList[active_index].description.ToString();
            gradeLabel.Text = CourseList[active_index].final_grade.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CourseList[active_index].delete())
            {
                MessageBox.Show("Deleted");
                this.Close();
            }
            else
            {
                MessageBox.Show("Issue Deleting");
            }
        }

        private void ViewCourses_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
