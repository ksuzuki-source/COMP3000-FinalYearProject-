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
    public partial class FormUserEdit : Form
    {
        int ID;
        string originalName, originalSex, originalRole, originalPassword, originalPostcode, originalDrivingLisence;
        DateTime originalBtD;
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;

        public FormUserEdit(int rcvID)
        {
            InitializeComponent();
            ID = rcvID;
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            // Create sql connection string
             Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);

            //open connection 
            Cnn.Open();

            //create select command
            try
            {
                //set the select method with ID
                Cmd = new SqlCommand("SELECT * FROM worker WHERE ID = " + ID, Cnn);
                //use sqldatareader becasue only 1 record is needed to load from database table
                SqlDataReader dr = Cmd.ExecuteReader();
                dr.Read();
                //take the strings from background record
                originalName = dr.GetString(1);
                originalSex = dr.GetString(2);
                originalRole = dr.GetString(3);
                originalPassword = dr.GetString(4);
                originalPostcode = dr.GetString(5);
                originalBtD = dr.GetDateTime(6);
                originalDrivingLisence = dr.GetString(7);


                txtName.Text = originalName;
                SexBox1.Text = originalSex;
                RoleBox2.Text = originalRole;
                txtPassword.Text = originalPassword;
                txtPostcode.Text = originalPostcode;
                txtAge.Text = originalBtD.ToString();
                txtDrivingLisence.Text = originalDrivingLisence;


                dr.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {

                Cnn.Close();
            }

        }

        private void RoleBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdCmd = new SqlCommand("UPDATE worker SET  Name = @Name, SEX = @SEX, Role = @Role," +
                   " Password = @Password, Postcode = @Postcode, DateofBirth = @DateofBirth, DrivingLisence = @DrivingLisence " +
                   "WHERE ID = @ID", Cnn);
            UpdCmd.Parameters.Add(new SqlParameter("@ID", ID));
            UpdCmd.Parameters.Add(new SqlParameter("@Name", txtName.Text));
            UpdCmd.Parameters.Add(new SqlParameter("@SEX", SexBox1.Text));
            UpdCmd.Parameters.Add(new SqlParameter("@Role", RoleBox2.Text));
            UpdCmd.Parameters.Add(new SqlParameter("@Password", txtPassword.Text));
            UpdCmd.Parameters.Add(new SqlParameter("@Postcode", txtPostcode.Text));
            UpdCmd.Parameters.Add(new SqlParameter("@DateofBirth", txtAge.Text));
            UpdCmd.Parameters.Add(new SqlParameter("@DrivingLisence", txtDrivingLisence.Text));

            try
            {
                //sql connection open 
                Cnn.Open();
                UpdCmd.ExecuteNonQuery();
                MessageBox.Show("Edited!!");

            }
            catch (Exception exception)
            {
                //if exception is cought, show the error message
                MessageBox.Show("Error!" + exception.Message);

            }
            finally
            {
                //close connection 
                Cnn.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure？", "Comfirmation", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    //if yes is clicked delete the record
                    DelCmd = new SqlCommand("DELETE FROM worker WHERE ID = @ID", Cnn);
                    DelCmd.Parameters.Add(new SqlParameter("@ID", ID));
                    UpdCmd.ExecuteNonQuery();
                    FormMain FM = new FormMain();
                    this.Close();
                    FM.Show();
                }
                catch (Exception exception)
                {
                    //if exception is cought, show the error message
                    MessageBox.Show("Error!" + exception.Message);

                }
                finally
                {
                    //close connection 
                    Cnn.Close();
                }
            }
            else
            { }
        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void btnShowBackground_Click(object sender, EventArgs e)
        {
            FormBackground FB = new FormBackground(ID,originalName);
            FB.Show();
        }

        private void btnWorkingRecord_Click(object sender, EventArgs e)
        {
            FormCheckWork FCK = new FormCheckWork(ID);
            FCK.Show();
        }


    }
}
