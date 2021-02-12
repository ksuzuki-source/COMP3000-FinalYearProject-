using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new FormAdminLogin();
            adminForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form workingForm = new FormWorkingTime();
            workingForm.Show();
        }
    }
}
