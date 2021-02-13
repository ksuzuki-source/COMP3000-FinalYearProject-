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
    public partial class FormViewData : Form
    {
        //using BindingSource and datatable to make the search function more flexible
        public BindingSource bindingSource1;
        public DataTable table;

        public FormViewData()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.table.DefaultView.RowFilter = "";
        }




        /// <summary>
        /// Function Section
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

                table =
                    Readcsv.read_csv(op.FileName);


                bindingSource1.DataSource = table;

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
                    csv.SaveDataTableAsCsv(table, sa.FileName);
                    table = Readcsv.read_csv(sa.FileName);


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



