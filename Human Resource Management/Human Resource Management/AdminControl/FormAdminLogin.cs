using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using CsvHelper;

namespace Human_Resource_Management
{
    public partial class FormAdminLogin : Form
    {
        string userName;
        string password;
        private BindingSource bindingSource1;
        private DataTable table;
        public FormAdminLogin(DataTable dataTable)
        {
            table = dataTable;
            InitializeComponent();
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminLogin();
        }

        /// <summary>
        /// Function Section
        /// </summary>


        public void AdminLogin()
        {
            userName = this.textBox1.Text;
            password = this.textBox2.Text;
            //string test = "data/test";
            //table = Readcsv.Read_csv(test + ".csv");
            bindingSource1.DataSource = table;
            int numOfrows = table.Rows.Count;
            int numOfcolumns = table.Columns.Count;
            string admin = "Admin";

            for (int j = 0; j < numOfrows; j++)
            {
                if (table.Rows[j][1].ToString() == userName)
                {
                    if (table.Rows[j][4].ToString() == password)
                    {
                        if (table.Rows[j][3].ToString() == admin)
                        {

                            MessageBox.Show("Success!");
                            FormViewData form2 = new FormViewData(table);
                            
                            form2.Show();
                            this.Close();
                            break;
                        }
                        else if (table.Rows[j][2].ToString() != admin)
                        {
                            MessageBox.Show("only admin can login to this form");
                        }
                    }
                }
                
                else if (j == numOfrows-1)
                {
                    MessageBox.Show("Tryagain");
                }

            }
            


        }
    }
}
