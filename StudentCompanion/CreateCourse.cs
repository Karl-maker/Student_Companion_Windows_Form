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
    public partial class CreateCourse : Form
    {
        Student student = Student.Instance;
        Course course = new Course();

        public CreateCourse()
        {
            InitializeComponent();
        }

        public CreateCourse(int semester_id) // If accessed from semester page
        {
            InitializeComponent();
            creditsInput.Value = course.credits;
            course.student_id = student.ID;
            course.semester_id = semester_id;
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {

        }

        private void courseCodeInput_TextChanged(object sender, EventArgs e)
        {
            course.code = courseCodeInput.Text;
        }

        private void courseNameInput_TextChanged(object sender, EventArgs e)
        {
            course.name = courseNameInput.Text;
        }

        private void descriptionInput_TextChanged(object sender, EventArgs e)
        {
            course.description = descriptionInput.Text;
        }

        private void creditsInput_ValueChanged(object sender, EventArgs e)
        {
            course.credits = Int32.Parse(creditsInput.Value.ToString());
        }

        private void gradeInput_TextChanged(object sender, EventArgs e)
        {
            course.final_grade = gradeInput.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (course.save())
            {
                MessageBox.Show("Saved");
                this.Close();
            } 
            else
            {
                MessageBox.Show("Issue Saving");
            }
        }
    }
}

