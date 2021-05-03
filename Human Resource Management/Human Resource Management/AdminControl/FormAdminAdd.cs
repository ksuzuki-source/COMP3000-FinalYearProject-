using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Human_Resource_Management
{
    public partial class FormAdminAdd : Form
    {
        public DataTable table;         
        public string filepath;
        public string path;
        public FormAdminAdd(DataTable rcvtable)          //take the arg value from previous form. So, this form also be able to refference same table 
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

      

        
        public void addNew()
        {

            if (txtName.Text != null && (SexBox1.Text == "M" || SexBox1.Text == "F" || SexBox1.Text == "O")           //check the input values
                && (RoleBox2.Text == "User" || RoleBox2.Text == "Admin")
                && txtPassword.Text != null
                && txtPostcode.Text != null
                && txtAge.Text != null)
            {
                DateTime date;
                if (DateTime.TryParse(txtAge.Text, out date))
                {
                    int ID = 0;
                    table.Rows.Add(ID, txtName.Text, SexBox1.Text, RoleBox2.Text,
                        txtPassword.Text, txtPostcode.Text, txtAge.Text, txtDrivingLisence.Text);   //if the value is valid, add new row to the table                     
                    FormViewData fvd = new FormViewData(table);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
                
            }

            else
            {
                MessageBox.Show("invalid input");
            }

            }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

