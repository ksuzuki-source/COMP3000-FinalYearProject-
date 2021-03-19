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
            FormAdminLogin fal = new FormAdminLogin();
            fal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUserLogin ful = new FormUserLogin();
            ful.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string path = "data/test.csv";
            DataTable table = Readcsv.Read_csv(path);
            FormRegister FR = new FormRegister(table, path);
            FR.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
