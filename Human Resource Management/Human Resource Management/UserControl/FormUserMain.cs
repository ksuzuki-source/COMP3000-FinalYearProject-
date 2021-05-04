using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormUserMain : Form
    {

        int ID;
        string Name;
        public FormUserMain(int rcvID, string rcvName)
        {
            InitializeComponent();
            ID = rcvID;
            Name = rcvName;


        }

        private void btnWTR_Click(object sender, EventArgs e)
        {
            FormWorkingTime FWT = new FormWorkingTime(ID, Name);
            FWT.Show();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormBackground FLD = new FormBackground(ID, Name);
            FLD.Show();
        }

        private void FormUserMain_Load(object sender, EventArgs e)
        {
            label1.Text = ("Welcome " + Name + "!!");
        }
    }
}
