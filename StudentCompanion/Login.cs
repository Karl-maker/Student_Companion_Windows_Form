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

            try
            {
                Student student = Student.Instance;
                if(student.login("karljohanbailey98@gmail.com", "password"))
                {
                    // User is logged In
                    MessageBox.Show("Login Successful");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
