using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Human_Resource_Management
{
    //this form is for viewing the data with CRUD  
    public partial class Form2 : Form
    {
        //using BindingSource and datatable to make the search function more flexible
        private BindingSource bindingSource1;
        private DataTable table;

        public Form2()
        {
            InitializeComponent();
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //press btn load to load the file with file dialog 
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SavefileDialog();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            SearchFilter();
        }



        /// <summary>
        /// below is some methods because table is private variable, I don`t want to change table from other class.
        /// </summary>




        public void OpenFileDialog()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "OPEN FILE";
            op.InitialDirectory = @"C:\";
            op.FileName = null;
            op.Filter = "CSV file(*.csv)|*.csv";
            op.FilterIndex = 1;

            DialogResult result = op.ShowDialog();
            if (result == DialogResult.OK)
            {

                this.table =
                    Readcsv.read_csv(op.FileName);


                this.bindingSource1.DataSource = this.table;

            }
            else if (result == DialogResult.Cancel)
            { }
        }


        public void SavefileDialog()
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "OPEN FILE";
            sa.InitialDirectory = @"C:\";
            sa.FileName = null;
            sa.Filter = "CSV file(*.csv)|*.csv";
            sa.FilterIndex = 1;

            if (table != null)
            {
                DialogResult result = sa.ShowDialog();
                if (result == DialogResult.OK)
                {
                     Savecsv csv = new Savecsv();
                    csv.SaveDataTableAsCsv(this.table, sa.FileName);
                    this.table = Readcsv.read_csv(sa.FileName);


                }
                else if (result == DialogResult.Cancel)
                { }
            }
            else
            {
                MessageBox.Show("Table is null");
            }

        }

        public void SearchFilter()
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                if (table != null)
                {
                    if (radioButton1.Checked)
                    {
                        this.table.DefaultView.RowFilter =
                        "NAME LIKE '%" +
                        this.textBox1.Text + "%'";


                        this.bindingSource1.ResetBindings(false);
                    }

                    else if (radioButton2.Checked)
                    {
                        this.table.DefaultView.RowFilter =
                        "SEX LIKE '%" +
                        this.textBox1.Text + "%'";

                        this.bindingSource1.ResetBindings(false);
                    }

                    else if (radioButton3.Checked)
                    {
                        this.table.DefaultView.RowFilter =
                        "ROLE LIKE '%" +
                        this.textBox1.Text + "%'";

                        this.bindingSource1.ResetBindings(false);
                    }


                    else
                    {
                        MessageBox.Show("category is not chaecked");

                    }
                }





                else if (table != null)
                {
                    this.table.DefaultView.RowFilter = "";
                }
                
            }

        }
    }
}



