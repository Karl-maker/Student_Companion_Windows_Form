using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;

namespace StudentCompanion
{
    public partial class Semesters : Form
    {
        Student student = Student.Instance;
        List<Semester> SemesterList = new List<Semester>();
        int active_index = 0;



        public Semesters()
        {
            InitializeComponent();

            // Add All Items To ComboBox

            Connection connect = new Connection();

            connect.command.Connection = connect.connection;

            connect.command.CommandText = "SELECT * from Semesters WHERE StudentID = " + student.ID + "";
            connect.reader = connect.command.ExecuteReader();

            while (connect.reader.Read())
            {
                // Add list to combobox and create list of semesters...

                // Paralle Arrays will help with selection

                SemesterList.Add(new Semester(Int32.Parse(connect.reader[0].ToString()), Int32.Parse(connect.reader[3].ToString()), DateTime.ParseExact(connect.reader[1].ToString(), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture), DateTime.ParseExact(connect.reader[2].ToString(), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)));
                semesterList.Items.Add("From "+ connect.reader[1].ToString() + " To " + connect.reader[2].ToString());


            }

            connect.closeConnection();

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Semesters_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void semesterList_SelectedIndexChanged(object sender, EventArgs e)
        {

            active_index = semesterList.SelectedIndex;

            startDateLabel.Text = SemesterList[active_index].start_date.ToString();
            endDateLabel.Text = SemesterList[active_index].end_date.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (SemesterList[active_index].delete())
            {
                MessageBox.Show("Deleted Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Unable To Delete");
            }
          
        }

        private void startDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            CreateCourse create_course = new CreateCourse(SemesterList[active_index].id);
            create_course.Show();
        }

        private void viewCourseButton_Click(object sender, EventArgs e)
        {
            ViewCourses couses_page = new ViewCourses(SemesterList[active_index].id);
            couses_page.Show();
        }
    }
}
