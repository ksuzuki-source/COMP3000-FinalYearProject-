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
    public partial class FormWorkingTime : Form
    {

        public string TmpWorkIn;
        public string TmpLeaveWork;
        public DateTime  WorkIn;
        public DateTime LeaveWork;
        public TimeSpan WorkingDur;
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;
        private SqlDataAdapter Dta;
        DataTable table = new DataTable();

        string name;
        int ID;
        public FormWorkingTime(int rcvID, string rcvName)
        {
            InitializeComponent();
            ID = rcvID;
            name = rcvName;
        }

        private void FormWorkingTime_Load(object sender, EventArgs e)
        {
            /////ここやる/////
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
            Cnn.Open();

            Cmd = new SqlCommand("SELECT * FROM WorkingRecord WHERE ID = " + ID, Cnn);

            InsCmd = new SqlCommand("INSERT INTO WorkingRecord (ID, Name WorkingIn, LeaveWorking, WorkingDuration) " +
                     "VALUES ( @ID, @Name @WorkingIn, @LeaveWorking, @WorkingDuration)", Cnn);
            InsCmd.Parameters.Add(new SqlParameter("@ID", ID));
            InsCmd.Parameters.Add(new SqlParameter("@Name", name));
            InsCmd.Parameters.Add(new SqlParameter("@WorkingIn", "WorkingIn"));
            InsCmd.Parameters.Add(new SqlParameter("@LeaveWorking", "LeaveWorking"));
            InsCmd.Parameters.Add(new SqlParameter("@WorkingDuration", "WorkingDuration"));

            UpdCmd = new SqlCommand("UPDATE WorkingRecord SET WorkingIn = @WorkingIn, LeaveWorking = @LeaveWorking," +
                " WorkingDuration = @WorkingDuration WHERE ID = @ID", Cnn);

            //UpdCmd.Parameters.Add(new SqlParameter("@ID", "ID"));
            UpdCmd.Parameters.Add(new SqlParameter("@WorkingIn", "WorkingIn"));
            UpdCmd.Parameters.Add(new SqlParameter("@LeaveWorking", "LeaveWorking"));
            UpdCmd.Parameters.Add(new SqlParameter("@WorkingDuration", "WorkingDuration"));

            Dta = new SqlDataAdapter(Cmd);
            Dta.SelectCommand = Cmd;
            Dta.InsertCommand = InsCmd;
            Dta.UpdateCommand = UpdCmd;
            Dta.DeleteCommand = DelCmd;
            Dta.Fill(table);
            Cnn.Close();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(ID, DateTime.Now, null, null);
            try
            {
                Cnn.Open();
                Dta.Update(table);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            finally
            {
                Cnn.Close();
            }
            MessageBox.Show("You are work in now!" + DateTime.Now);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {

            fncLeaveWork();
        }



        public void fncLeaveWork()
        {
            int latestRow = table.Rows.Count - 1;
            if (table.Rows[latestRow][3].ToString() == "")
            {
                table.Rows[latestRow][2] = DateTime.Now;
                TmpWorkIn = (string)table.Rows[latestRow][1];
                TmpLeaveWork = (string)table.Rows[latestRow][2];
                WorkIn = DateTime.Parse(TmpWorkIn);
                LeaveWork = DateTime.Parse(TmpLeaveWork);

                TimeSpan ts1 = LeaveWork - WorkIn;         //culculate the working time with leave time - work in time
                table.Rows[latestRow][3] = ts1.ToString();

                try
                {
                    Cnn.Open();
                    Dta.Update(table);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
                finally
                {
                    Cnn.Close();
                }
                MessageBox.Show("You are work in now!" + DateTime.Now);
            }

        
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FormCheckWork fcw = new FormCheckWork(ID);
            fcw.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
