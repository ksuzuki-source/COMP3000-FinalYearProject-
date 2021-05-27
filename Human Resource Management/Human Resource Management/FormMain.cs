using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Human_Resource_Management
{
    public partial class FormMain : Form
    {
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;
        private SqlDataAdapter Dta;
        DataTable table = new DataTable();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
            Cnn.Open();

            Cmd = new SqlCommand("SELECT * FROM worker", Cnn);
            Dta = new SqlDataAdapter(Cmd);
            Dta.Fill(table);
            Cnn.Close();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminLogin fal = new FormAdminLogin(table);
            fal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cnn.Open();
            table.Clear();
            Dta.Fill(table);
            Cnn.Close();
            FormUserLogin ful = new FormUserLogin(table);
            ful.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            FormRegister FR = new FormRegister(table);
            FR.Show();
        }

        
    }
}
