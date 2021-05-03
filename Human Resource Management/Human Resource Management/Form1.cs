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
    public partial class Form1 : Form
    {

        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;
        private SqlDataAdapter Dta;
        private SqlTransaction Txn;

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
            Cnn.Open();

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT");
            sql.AppendLine("  *");
            sql.AppendLine("FROM worker");

            Cmd = new SqlCommand("SELECT * FROM worker", Cnn);
            Dta = new SqlDataAdapter(Cmd);
            
            InsCmd = new SqlCommand("INSERT INTO worker (Name, SEX, Role, Password, Postcode, DateofBirth, DrivingLisence) " +
                     "VALUES ( @Name, @SEX, @Role, @Password, @Postcode, @DateofBirth, @DrivingLisence)", Cnn);

            InsCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            InsCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            InsCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, "SEX");
            InsCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, "Role");
            InsCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, "Password");
            InsCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, "Postcode");
            InsCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, "DateofBirth");
            InsCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, "DrivingLisence");

            


            DelCmd = new SqlCommand("DELETE FROM worker WHERE ID = @ID", Cnn);
            DelCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");

            Dta.SelectCommand = Cmd;
            Dta.InsertCommand = InsCmd;
            Dta.UpdateCommand = UpdCmd;
            Dta.DeleteCommand = DelCmd;
            Dta.Fill(dt);
            dataGridView1.DataSource = dt;
            Cnn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                UpdCmd = new SqlCommand("UPDATE worker SET  Name = @Name, SEX = @SEX, Role = @Role," +
                    " Password = @Password, Postcode = @Postcode, DateofBirth = @DateofBirth, DrivingLisence = @DrivingLisence " +
                    "WHERE ID = @ID", Cnn);
                UpdCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
                UpdCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
                UpdCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, "SEX");
                UpdCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, "Role");
                UpdCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, "Password");
                UpdCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, "Postcode");
                UpdCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, "DateofBirth");
                UpdCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, "DrivingLisence");
                //UpdCmd.Parameters.Add("@ID", SqlDbType.Int, 4, (int)dataGridView1.Rows[i].Cells[0].Value);
                //UpdCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, (string)dataGridView1.Rows[i].Cells[1].Value);
                //UpdCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, (string)dataGridView1.Rows[i].Cells[2].Value);
                //UpdCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, (string)dataGridView1.Rows[i].Cells[3].Value);
                //UpdCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, (string)dataGridView1.Rows[i].Cells[4].Value);
                //UpdCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, (string)dataGridView1.Rows[i].Cells[5].Value);
                //UpdCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, (string)dataGridView1.Rows[i].Cells[6].Value);
                //UpdCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, (string)dataGridView1.Rows[i].Cells[7].Value);
            }
            Dta.UpdateCommand = UpdCmd;

            Dta.Update(dt);
            dt.Clear();
            Dta.Fill(dt);
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
