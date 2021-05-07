using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{

    public partial class FormEdit : Form
    {
        public DataTable table;
        int ID;
        public int i;
        public string path;
        


        //FormViewData fvd = new FormViewData(table);
        public FormEdit(DataTable rcvtable, int rcvID)
        {
            //recieve table data and selected user ID data
            InitializeComponent();
            table = rcvtable;
            ID = rcvID;
            
        }

        

        private void FormEdit_Load(object sender, EventArgs e)
        {

            string originalName, originalSex, originalRole, originalPassword, originalPostcode,  originalDrivingLisence;
            DateTime originalBtD;

            //get the user data from table with ID
            for (i = 0; i < table.Rows.Count; i++)
            {
                if ((int)table.Rows[i][0] == ID)
                {
                    originalName = (string)table.Rows[i][1];
                    originalSex = (string)table.Rows[i][2];
                    originalRole = (string)table.Rows[i][3];
                    originalPassword = (string)table.Rows[i][4];
                    originalPostcode = (string)table.Rows[i][5];
                    originalBtD = (DateTime)table.Rows[i][6];
                    originalDrivingLisence = (string)table.Rows[i][7];

                    txtName.Text = originalName;
                    SexBox1.Text = originalSex;
                    RoleBox2.Text = originalRole;
                    txtPassword.Text = originalPassword;
                    txtPostcode.Text = originalPostcode;
                    txtAge.Text = originalBtD.ToString();
                    txtDrivingLisence.Text = originalDrivingLisence;
                    break;
                }
                

            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void Edit()
        {


              //check the validation of user input
            if (txtName.Text != null && (SexBox1.Text == "M" || SexBox1.Text == "F" || SexBox1.Text == "O")           //check the input values
                    && (RoleBox2.Text == "User" || RoleBox2.Text == "Admin")
                    && txtPassword.Text != null
                    && txtPostcode.Text != null
                    && txtAge.Text != null)
            {
                try
                {
                    table.Rows[i][1] = txtName.Text;
                    table.Rows[i][2] = SexBox1.Text;
                    table.Rows[i][3] = RoleBox2.Text;
                    table.Rows[i][4] = txtPassword.Text;
                    table.Rows[i][5] = txtPostcode.Text;
                    table.Rows[i][6] = txtAge.Text;
                    table.Rows[i][7] = txtDrivingLisence.Text;
                    MessageBox.Show("Edited");
                    //bring the table back to the previous form
                    FormViewData fvd = new FormViewData(table);
                    this.Close();
            }
                catch(Exception)
                {
                    MessageBox.Show("Invalid value is found");
                }
            }
                    //if invalid input is found, pop the error message
                    else
                    {
                        MessageBox.Show("Invalid value is found");
                    }

            



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            for (i = 0; i < table.Rows.Count; i++)
            {
                if ((int)table.Rows[i][0] == ID)
                {
                    //Confirm the delete data
                    DialogResult dr = MessageBox.Show(
                        "Record of" + table.Rows[i][0] + "will be deleted." + Environment.NewLine + "Are you sure?", "Comfirmation", MessageBoxButtons.YesNo);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        table.Rows.Remove(table.Rows[i]);
                    }
                }
            }
            this.Close();
        }


        private void btnShowCV_Click(object sender, EventArgs e)
        {
            FormCV FCV = new FormCV(txtName.Text);
            FCV.Show();
        }

        private void btnShowBackground_Click(object sender, EventArgs e)
        {
            //open the chosen user background form 
            string Name = txtName.Text;
            FormBackground FBG = new FormBackground(ID, Name);
            FBG.Show();
        }

        private void btnWorkingRecord_Click(object sender, EventArgs e)
        {
            //open the chosen user Working record form 
            FormCheckWork FCW = new FormCheckWork(ID);
            FCW.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
