using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormAdd : Form
    {
        public DataTable table;         
        public string filepath;
        public FormAdd(DataTable rcvtable)          //take the arg value from previous form. So, this form also be able to refference same table 
        {
            InitializeComponent();
            table = rcvtable;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew();                                           //call function 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormViewData fvd = new FormViewData(table);             //close form if canceled 
            
            this.Close();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress_1(object sender, KeyPressEventArgs e)          //make the limitationfor input value, only input the integer for the age. 
        {
            if ('0' <= e.KeyChar && e.KeyChar <= '9')
            {

            }
            else if (e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        
        public void addNew()
        {
            
            int count = 0;
            if (txtName.Text != null && (selectSex.Text == "Man" || selectSex.Text == "Female" || selectSex.Text == "Other")           //check the input values
                && (selectRole.Text == "User" || selectRole.Text == "Admin")
                && txtPassword.Text != null
                && txtPostcode.Text != null
                && txtAge.Text != null)
            {


                int a = Convert.ToInt32(txtAge.Text);       //convert into int

                for (int i = 0; i < table.Rows.Count; i++)
                    if (txtName.Text == (string)table.Rows[i][0])
                    {
                        MessageBox.Show("this name is already exist, please add something at the end of name");
                    }
                    else
                    {
                        count += 1;

                    }


                if (count == table.Rows.Count)
                {
                    if (a > 0 && a < 99)
                    {
                        table.Rows.Add(txtName.Text, selectSex.Text, selectRole.Text, txtPassword.Text, txtPostcode.Text, txtAge.Text);   //if the value is valid, add new row to the table
                        Savecsv sc = new Savecsv();
                        sc.SaveDataTableAsCsv(table, "test.csv");
                        DataTable wktable = new DataTable();            //create new table and new file automatically with the input name 
                        wktable.Columns.Add("Working in", typeof(DateTime));
                        wktable.Columns.Add("Leave work", typeof(DateTime));
                        wktable.Columns.Add("Working Duration", typeof(DateTime));
                        wktable.Rows.Add(DateTime.Now, DateTime.Now);           //initialize with account created date      
                        Savecsv sa = new Savecsv();
                        sa.SaveDataTableAsCsv(wktable, "data/WorkingData" + txtName.Text + ".csv");
                        FormViewData fvd = new FormViewData(table);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("invalid input");
                    }
                }
            else
            {
                MessageBox.Show("invalid input");
            }

            }
        }
    }
}
