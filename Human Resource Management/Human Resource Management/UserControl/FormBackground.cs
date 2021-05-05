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
    public partial class FormBackground : Form
    {
        string path;
        int ID;
        string background;
        string Name;
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;

        public FormBackground(int rcvID, string rcvName)
        {
            InitializeComponent();
            ID = rcvID;
            Name = rcvName;
        }

        private void FormLabourDetails_Load(object sender, EventArgs e)
        {
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);

            Cnn.Open();

            try
            {
                Cmd = new SqlCommand("SELECT * FROM BackGrounds WHERE ID = " + ID, Cnn);
                SqlDataReader dr = Cmd.ExecuteReader();
                dr.Read();
                background = dr.GetString(2);
                Name = dr.GetString(1);
                textBox1.Clear();
                textBox1.Text = background;
                dr.Close();
            }

            catch (Exception)
            { }
            finally
            {
                
                Cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelCmd = new SqlCommand("DELETE FROM BackGrounds WHERE ID = @ID", Cnn);
            DelCmd.Parameters.Add(new SqlParameter("@ID", ID));

            InsCmd = new SqlCommand("INSERT INTO BackGrounds( ID, Name, BackGround) VALUES (@ID, @Name, @BackGround)", Cnn);

            InsCmd.Parameters.Add(new SqlParameter("@ID", ID));
            InsCmd.Parameters.Add(new SqlParameter("@Name", Name));
            InsCmd.Parameters.Add(new SqlParameter("@BackGround", textBox1.Text));

            //UpdCmd = new SqlCommand("UPDATE BackGrounds SET Name = " + Name + ", BackGround = " + textBox1.Text + " WHERE ID = " + ID, Cnn);
            UpdCmd = new SqlCommand("UPDATE BackGrounds SET Name = @Name, BackGround = @BackGround WHERE ID = @ID", Cnn );
            UpdCmd.Parameters.Add(new SqlParameter("@ID", ID));
            UpdCmd.Parameters.Add(new SqlParameter("@Name", Name));
            UpdCmd.Parameters.Add(new SqlParameter("@BackGround", textBox1.Text));

            try
            {
                Cnn.Open();
                DelCmd.ExecuteNonQuery();
                InsCmd.ExecuteNonQuery();
                MessageBox.Show("Saved");

            }
            catch(Exception exception)
            {
                MessageBox.Show("Error!" + exception.Message);
                
            }
            finally
            {
                Cnn.Close();
                this.Close();
            }

        }
    }
}