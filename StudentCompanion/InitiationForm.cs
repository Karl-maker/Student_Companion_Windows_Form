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
    public partial class InitiationForm : Form
    {
        public InitiationForm()
        {
            InitializeComponent();
        }

        private void InitiationForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

        }
    }
}
