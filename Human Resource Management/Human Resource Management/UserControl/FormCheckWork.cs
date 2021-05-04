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
    public partial class FormCheckWork : Form
    {
        public BindingSource bindingSource1;
        DataTable table;
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;
        private SqlDataAdapter Dta;
        int ID;
        public FormCheckWork(int rcvID)
        {
            InitializeComponent();
            ID = rcvID;
            
            
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
            this.dataGridView1.DataSource = this.bindingSource1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
                       
            try
            {
                Cmd = new SqlCommand("SELECT * FROM WorkingRecord WHERE " + ID, Cnn);
                Dta = new SqlDataAdapter(Cmd);
                Dta.SelectCommand = Cmd;
                
                Cnn.Open();                
                Dta.Fill(table);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                Cnn.Close();
            }
            label1.Text = ("This is your working record");
            bindingSource1.DataSource = table;
        }
    }
}
