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

            InsCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            InsCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            InsCmd.Parameters.Add("@WorkingIn", SqlDbType.DateTime, 22, "WorkingIn");
            InsCmd.Parameters.Add("@LeaveWorking", SqlDbType.DateTime, 22, "LeaveWorking");
            InsCmd.Parameters.Add("@WorkingDuration", SqlDbType.Time, 8, "WorkingDuration");



            //InsCmd.Parameters.Add(new SqlParameter("@ID", ID));
            //InsCmd.Parameters.Add(new SqlParameter("@Name", name));
            //InsCmd.Parameters.Add(new SqlParameter("@WorkingIn", WorkIn));
            //InsCmd.Parameters.Add(new SqlParameter("@LeaveWorking", LeaveWork)) ;
            //InsCmd.Parameters.Add(new SqlParameter("@WorkingDuration", WorkingDur));

            UpdCmd = new SqlCommand("UPDATE WorkingRecord SET WorkingIn = @WorkingIn, LeaveWorking = @LeaveWorking," +
                " WorkingDuration = @WorkingDuration WHERE WorkingIn = @WorkingIn", Cnn);

            UpdCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            UpdCmd.Parameters.Add("@WorkingIn", SqlDbType.DateTime, 22, "WorkingIn");
            UpdCmd.Parameters.Add("@LeaveWorking", SqlDbType.DateTime, 22, "LeaveWorking");
            UpdCmd.Parameters.Add("@WorkingDuration", SqlDbType.Time, 8, "WorkingDuration");

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

            //textBox1.Text = table.Columns[4].DataType.ToString();


        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            WorkIn = DateTime.Now;
            LeaveWork = (DateTime)System.Data.SqlTypes.SqlDateTime.Null;
            
            //string time = WorkIn.ToString("MM-dd-yyyy HH:mm:ss");
            //WorkIn = DateTime.Parse(time);
            table.Rows.Add(ID, name, WorkIn, LeaveWork, WorkingDur);
            dataGridView1.DataSource = table;
            //textBox1.Text = time;
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
            DateTime minValue = (DateTime)System.Data.SqlTypes.SqlDateTime.Null;
            int latestRow = table.Rows.Count - 1;
            textBox1.Text = minValue.ToString();
            if (table.Rows[latestRow][3].ToString() == minValue.ToString())
            {
                table.Rows[latestRow][3] = DateTime.Now;
                //TmpWorkIn = (string)table.Rows[latestRow][2];
                //TmpLeaveWork = (string)table.Rows[latestRow][3];
                //WorkIn = DateTime.Parse(TmpWorkIn);
                //LeaveWork = DateTime.Parse(TmpLeaveWork);
                WorkIn = (DateTime)table.Rows[latestRow][2];
                LeaveWork = (DateTime)table.Rows[latestRow][3];
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
                    
                }
                finally
                {
                    Cnn.Close();
                }
                MessageBox.Show("Well done, you have worked for" + ts1);
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
