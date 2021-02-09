using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class Form3 : Form
    {
        private BindingSource bindingSource1;
        private DataTable table;
        public Form3()
        {
            InitializeComponent();
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
        }
    }
}
