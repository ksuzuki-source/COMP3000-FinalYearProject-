using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormUserLogin : Form
    {
        string userName;
        string password;
        private BindingSource bindingSource1;
        private DataTable table;
        public FormUserLogin()
        {
            InitializeComponent();
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
        }

        public void Login()
        {
            userName = this.textBox1.Text;
            password = this.textBox2.Text;
            string test = "test";
            table = Readcsv.Read_csv(test + ".csv");
            bindingSource1.DataSource = table;
            int numOfrows = table.Rows.Count;
            int numOfcolumns = table.Columns.Count;



            for (int j = 0; j < numOfrows; j++)
            {
                if (table.Rows[j][0].ToString() == userName)
                {
                    if (table.Rows[j][3].ToString() == password)
                    {
                        MessageBox.Show("Success!");
                        FormWorkingTime fwt = new FormWorkingTime("data/" + userName + ".csv");

                        fwt.Show();
                        this.Hide();
                        break;
                    }
                    else MessageBox.Show("Tryagain");
                }

                else if (j == numOfrows - 1)
                {
                    MessageBox.Show("Tryagain");
                }

                else
                {
                    continue;
                }
            }



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
