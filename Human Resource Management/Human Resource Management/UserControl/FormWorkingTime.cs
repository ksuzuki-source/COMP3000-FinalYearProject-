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
        System.Data.SqlTypes.SqlDateTime time;
        public string TmpWorkIn;
        public string TmpLeaveWork;
        private DateTime WorkIn;
        private DateTime LeaveWork;
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

            InsCmd = new SqlCommand("INSERT INTO WorkingRecord (ID, Name, WorkingIn, LeaveWorking, WorkingDuration) " +
                     "VALUES ( @ID, @Name, @WorkingIn, @LeaveWorking, @WorkingDuration)", Cnn);
            InsCmd.Parameters.Add(new SqlParameter("@ID", ID));
            InsCmd.Parameters.Add(new SqlParameter("@Name", name));
            InsCmd.Parameters.Add(new SqlParameter("@WorkingIn", WorkIn));
            InsCmd.Parameters.Add(new SqlParameter("@LeaveWorking", System.Data.SqlTypes.SqlDateTime.Null)) ;
            InsCmd.Parameters.Add(new SqlParameter("@WorkingDuration", WorkingDur));

            UpdCmd = new SqlCommand("UPDATE WorkingRecord SET WorkingIn = @WorkingIn, LeaveWorking = @LeaveWorking," +
                " WorkingDuration = @WorkingDuration WHERE ID = @ID", Cnn);

            //UpdCmd.Parameters.Add(new SqlParameter("@ID", "ID"));
            UpdCmd.Parameters.Add(new SqlParameter("@WorkingIn", WorkIn));
            UpdCmd.Parameters.Add(new SqlParameter("@LeaveWorking", LeaveWork));
            UpdCmd.Parameters.Add(new SqlParameter("@WorkingDuration", WorkingDur));

            Dta = new SqlDataAdapter(Cmd);
            Dta.SelectCommand = Cmd;
            Dta.InsertCommand = InsCmd;
            Dta.UpdateCommand = UpdCmd;
            Dta.DeleteCommand = DelCmd;


            //table.Columns[2].DataType = typeof(DateTime);
            //table.Columns[3].DataType = typeof(DateTime);
            //table.Columns[4].DataType = typeof(DateTime);
            Dta.Fill(table);

            Cnn.Close();

            textBox1.Text = name.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            WorkIn = DateTime.Now;
            //LeaveWork = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            
            //string time = WorkIn.ToString("MM-dd-yyyy HH:mm:ss");

            table.Rows.Add(ID, Name, WorkIn, System.Data.SqlTypes.SqlDateTime.Null, WorkingDur);
            dataGridView1.DataSource = table;
            try
            {

                Cnn.Open();
                Dta.Update(table);
                //Dta.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
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
                table.Rows[latestRow][3] = DateTime.Now;
                TmpWorkIn = (string)table.Rows[latestRow][2];
                TmpLeaveWork = (string)table.Rows[latestRow][3];
                WorkIn = DateTime.Parse(TmpWorkIn);
                LeaveWork = DateTime.Parse(TmpLeaveWork);

                TimeSpan ts1 = LeaveWork - WorkIn;         //culculate the working time with leave time - work in time
                table.Rows[latestRow][4] = ts1;

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
            else 
            {
                MessageBox.Show("You have not worked in");
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
