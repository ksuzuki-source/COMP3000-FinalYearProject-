using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    //this is a form to login for user menu
    public partial class FormUserLogin : Form
    {
        string userName;
        string password;
        private DataTable table;
        public FormUserLogin(DataTable dataTable)
        {
            //recieve the datatable from prev form
            table = dataTable;
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }


        public void Login()
        {
            //take the value from user input
            userName = this.textBox1.Text;
            password = this.textBox2.Text;

            int numOfrows = table.Rows.Count;
            int numOfcolumns = table.Columns.Count;


            //check the record with user input username and password    
            for (int j = 0; j < numOfrows; j++)
            {
                if (table.Rows[j][1].ToString() == userName)
                {
                    if (table.Rows[j][4].ToString() == password)
                    {
                        //set the ID and name variable to pass to next form
                        string ID = table.Rows[j][0].ToString();
                        string Name = table.Rows[j][1].ToString();
                        int sendID = Int32.Parse(ID);
                        MessageBox.Show("Success!");
                        
                        //open user main form with ID and user name
                        FormUserMain FUM = new FormUserMain(sendID, Name);
                        FUM.Show();
                        //fwt.Show();
                        this.Close();
                        break;
                    }


                }

                else if (j == numOfrows-1)
                {
                    //if wrong username or password is found, error message is pop
                    MessageBox.Show("Username or Password is wrong");
                }
                
            }




        }


    }
}
