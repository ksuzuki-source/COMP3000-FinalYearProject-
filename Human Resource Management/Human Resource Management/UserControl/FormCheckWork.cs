using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Human_Resource_Management
{
    //this is a form to check the user working record
    public partial class FormCheckWork : Form
    {
        public BindingSource bindingSource1;
        private DataTable Table = new DataTable();
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
            //create sql connection string
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
                       
            try
            {
                //create select command
                Cmd = new SqlCommand("SELECT * FROM WorkingRecord WHERE ID = " + ID, Cnn);
                Dta = new SqlDataAdapter(Cmd);
                Dta.SelectCommand = Cmd;
                //connection open
                Cnn.Open();               
                //fill the table and show them up at the datagridview
                Dta.Fill(Table);
            }
            catch (Exception exception)
            {
                //if exception is caught, show the error message
                MessageBox.Show(exception.Message);
               
            }
            finally
            {
                //close connection 
                Cnn.Close();
            }
            //set the user name in label at top of form
            label1.Text = ("This is your working record");
            bindingSource1.DataSource = Table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                this.Table.DefaultView.RowFilter =
                          "WorkingIn >= #" + textBox1.Text + " # and WorkingIn <= #" + textBox2.Text + " #";

            }
            else
                MessageBox.Show("enter start date and end date");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "OPEN FILE";
            sa.InitialDirectory = @"C:\";
            sa.FileName = null;
            sa.Filter = "CSV file(*.csv)|*.csv";
            sa.FilterIndex = 1;

            DialogResult result = sa.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sa.FileName, false, Encoding.Default);


                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {

                        sw.Write(dataGridView1[j, i].Value + ",");

                    }
                    sw.WriteLine();
                }
                sw.Close();
                MessageBox.Show("Exported！！");
            }
            else if (result == DialogResult.Cancel)
            { }
            

            
        }
    }
}
