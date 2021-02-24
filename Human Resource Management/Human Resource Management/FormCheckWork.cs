using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Human_Resource_Management
{
    public partial class FormCheckWork : Form
    {
        public BindingSource bindingSource1;
        DataTable table;
        string path;
        public FormCheckWork(DataTable rcvTable, string rcvpath)
        {
            InitializeComponent();
            table = rcvTable;
            path = rcvpath;
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = ("This is your working record");
            bindingSource1.DataSource = table;
        }
    }
}
