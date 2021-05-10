using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    //this is a form to navigate user to other functions
    public partial class FormUserMain : Form
    {

        int ID;
        string Name;
        public FormUserMain(int rcvID, string rcvName)
        {
            //recieve the ID and name from prev form 
            InitializeComponent();
            ID = rcvID;
            Name = rcvName;


        }

        private void btnWTR_Click(object sender, EventArgs e)
        {
            //send variables to work time record form
            FormWorkingTime FWT = new FormWorkingTime(ID, Name);
            FWT.Show();
        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            //send variables to background form
            FormBackground FLD = new FormBackground(ID, Name);
            FLD.Show();
        }

        private void FormUserMain_Load(object sender, EventArgs e)
        {
            label1.Text = ("Welcome " + Name + "!!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormUserEdit FUE = new FormUserEdit(ID);
            FUE.Show();
        }
    }
}
