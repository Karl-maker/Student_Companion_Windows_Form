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
    public partial class CreateSemester : Form
    {

        Student student = Student.Instance;
        Semester semester = new Semester();

        public CreateSemester()
        {
            InitializeComponent();
            semester.student_id = student.ID;
            semester.start_date = startDatePicker.Value;
            semester.end_date = endDatePicker.Value;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (semester.save())
            {
                MessageBox.Show("Saved Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Issue Saving");
            }
            
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
           semester.start_date = startDatePicker.Value;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            semester.end_date = endDatePicker.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateSemester_Load(object sender, EventArgs e)
        {

        }
    }
}
