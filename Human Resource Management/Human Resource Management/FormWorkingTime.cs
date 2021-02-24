using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormWorkingTime : Form
    {
        public string path;
        public DataTable table;
        public string TmpWorkIn;
        public string TmpLeaveWork;
        public DateTime  WorkIn;
        public DateTime LeaveWork;
        public FormWorkingTime(string rcvpath)
        {
            InitializeComponent();
            path = rcvpath;
        }

        private void FormWorkingTime_Load(object sender, EventArgs e)
        {
            table = Readcsv.Read_PersonCsv(path);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            fncWorkIn();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {

            fncLeaveWork();
        }


        public void fncWorkIn()
        {
            table.Rows.Add(DateTime.Now);           //add new row and give the date
            Savecsv sc = new Savecsv();
            sc.SaveDataTableAsCsv(table, path);
            MessageBox.Show("recorded!" + DateTime.Now);
        }

        public void fncLeaveWork()
        {
            int latestRow = table.Rows.Count - 1;
            if (table.Rows[latestRow][1].ToString() == "")
            {
                table.Rows[latestRow][1] = DateTime.Now;
                TmpWorkIn = (string)table.Rows[latestRow][0];
                TmpLeaveWork = (string)table.Rows[latestRow][1];
                WorkIn = DateTime.Parse(TmpWorkIn);
                LeaveWork = DateTime.Parse(TmpLeaveWork);

                TimeSpan ts1 = LeaveWork - WorkIn;         //culculate the working time with leave time - work in time
                table.Rows[latestRow][2] = ts1.ToString();

                MessageBox.Show("recorded!" + DateTime.Now);
                Savecsv sc = new Savecsv();                 //save to file 
                sc.SaveDataTableAsCsv(table, path);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            FormCheckWork fcw = new FormCheckWork(table, path);
            fcw.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
