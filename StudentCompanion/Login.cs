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


    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();
      
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            Student student = Student.Instance;

            try
            {
                
                if (student.login(emailTextBox.Text, passwordTextBox.Text))
                {
                    // User is logged In
                    MessageBox.Show("Welcome " + student.first_name);
 
                    this.Close(); // closes this instance.
                }
                else
                {
                    MessageBox.Show("Incorrect Password or Email");
                }


            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error);
            }


        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            this.Close();
        }
    }
}
