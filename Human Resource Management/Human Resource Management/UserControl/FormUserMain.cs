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
        string path;
        string sendpath;
        public FormUserMain(string rcvopath)
        {
            InitializeComponent();
            path = rcvopath;
            sendpath = rcvopath;
        }

        private void btnWTR_Click(object sender, EventArgs e)
        {
            FormWorkingTime FWT = new FormWorkingTime(path);
            FWT.Show();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            FormCV FCV = new FormCV(path);
            FCV.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormBackground FLD = new FormBackground(path);
            FLD.Show();
        }
    }
}
