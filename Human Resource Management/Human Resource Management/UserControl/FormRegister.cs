using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Human_Resource_Management
{
    //this is a form to register for new user
    public partial class FormRegister : Form
    {
        public DataTable table;
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand InsBGCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;
        private SqlDataAdapter Dta;
        int max = 8000;
        public FormRegister(DataTable rcvtable)
        {
            InitializeComponent();

            table = rcvtable;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            //create sql connection string
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
            //create data adapter to commuicate with sql server
            Dta = new SqlDataAdapter(Cmd);
            //connection open
            Cnn.Open();

            //create insert command with user input values
            InsCmd = new SqlCommand("INSERT INTO worker (Name, SEX, Role, Password, Postcode, DateofBirth, DrivingLisence) " +
                     "VALUES ( @Name, @SEX, @Role, @Password, @Postcode, @DateofBirth, @DrivingLisence)", Cnn);

            //InsCmd.Parameters.Add(new SqlParameter("@ID", "ID"));
            //InsCmd.Parameters.Add(new SqlParameter("@Name", "Name"));
            //InsCmd.Parameters.Add(new SqlParameter("@SEX", "SEX"));
            //InsCmd.Parameters.Add(new SqlParameter("@Role", "Role"));
            //InsCmd.Parameters.Add(new SqlParameter("@Password", "Password"));
            //InsCmd.Parameters.Add(new SqlParameter("@Postcode", "Postcode"));
            //InsCmd.Parameters.Add(new SqlParameter("@DateofBirth", "DateofBirth"));
            //InsCmd.Parameters.Add(new SqlParameter("@DrivingLisence", "DrivingLisence"));
            
            //add parameters to each values to insert 
            InsCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            InsCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            InsCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, "SEX");
            InsCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, "Role");
            InsCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, "Password");
            InsCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, "Postcode");
            InsCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, "DateofBirth");
            InsCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, "DrivingLisence");





            Dta.SelectCommand = Cmd;
            Dta.InsertCommand = InsCmd;
            Dta.UpdateCommand = UpdCmd;
            Dta.DeleteCommand = DelCmd;

            Cnn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void addNew()
        {

            //check the user input validations
            if (txtName.Text != null && (SexBox1.Text == "M" || SexBox1.Text == "F" || SexBox1.Text == "O")           //check the input values
                && (RoleBox2.Text == "User" || RoleBox2.Text == "Admin")
                && txtPassword.Text != null
                && txtPostcode.Text != null
                && txtAge.Text != null)
            {
                DateTime date;
                if (DateTime.TryParse(txtAge.Text, out date))
                {
                    //add a new row into the table with values
                    int ID = 0;
                    table.Rows.Add(ID, txtName.Text, SexBox1.Text, RoleBox2.Text,
                        txtPassword.Text, txtPostcode.Text, txtAge.Text, txtDrivingLisence.Text);   //if the value is valid, add new row to the table                     

                    try
                    {
                        //connection opne 
                        Cnn.Open();

                        //call update method with table argument
                        Dta.Update(table);
                        MessageBox.Show("User is added");
                    }
                    catch (Exception exception)
                    {
                        //show up error message if exception is found
                        MessageBox.Show(exception.Message);
                        
                    }
                    finally
                    {
                        //connection close
                        Cnn.Close();
                    }

                    this.Close();
                }
                else
                {
                    //if invalid value is found, show up error message
                    MessageBox.Show("Invalid input");
                }

            }

            else
            {
                MessageBox.Show("invalid input");
            }
        }


    }
}
