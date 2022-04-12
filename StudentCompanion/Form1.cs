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
    
  
    public partial class Form1 : Form
    {
        Student student = new Student();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hi";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
