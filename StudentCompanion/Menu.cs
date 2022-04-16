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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            Student student = Student.Instance;
            studentNameLabel.Text = student.first_name + student.last_name;
            studentEmailLabel.Text = student.email;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Semesters semester_page = new Semesters();
            semester_page.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void addSemesterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateSemester create_semester = new CreateSemester();
            create_semester.Show();
        }

        private void viewCourseLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewCourses courses_page = new ViewCourses();
            courses_page.Show();
        }
    }
}
