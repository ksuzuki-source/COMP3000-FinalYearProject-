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
        public DateTime WorkIn;
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
            table.Rows.Add(DateTime.Now.ToString());           //add new row and give the date
            Savecsv sc = new Savecsv();
            sc.SaveDataTableAsCsv(table, path);
            MessageBox.Show("recorded!" + DateTime.Now);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if(table.Rows[i][1] == null || (string)table.Rows[i][1] == "")                
                {   
                    table.Rows[i][1] = DateTime.Now.ToString();

                    table.Rows[i][0] = WorkIn;
                    table.Rows[i][1] = LeaveWork;

                    TimeSpan ts1 = LeaveWork - WorkIn;         //culculate the working time with leave time - work in time
                    table.Rows[i][2] = ts1.ToString();

                    MessageBox.Show("recorded!" + DateTime.Now);
                    Savecsv sc = new Savecsv();                 //save to file 
                    sc.SaveDataTableAsCsv(table, path);

                }
                //if(table.Rows[i][2] == null)
                //{
                  //  table.Rows[i][0] = WorkIn;
                    //table.Rows[i][1] = LeaveWork;

                   // TimeSpan ts1 = LeaveWork - WorkIn;         //culculate the working time with leave time - work in time
                    //table.Rows[i][2] = ts1.ToString();

                    //Savecsv sc = new Savecsv();                 //save to file 
                   //sc.SaveDataTableAsCsv(table, path);
               // }
            }
        }
    }
}
