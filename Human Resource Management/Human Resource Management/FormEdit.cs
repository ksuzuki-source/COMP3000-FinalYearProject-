﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
            FormViewData FVD;
        }


        string updateName;
        string updateSex;
        string updateRole;
        string updatePassword;
        string updatePostcode;
        string updateAge;
    }
}