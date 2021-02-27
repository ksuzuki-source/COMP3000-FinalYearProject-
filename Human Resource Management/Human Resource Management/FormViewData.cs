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
        public string path;
        

        public FormViewData(DataTable dataTable)
        {
            InitializeComponent();
            table = dataTable;
            this.components = new Container();
            this.bindingSource1 =
                new BindingSource(this.components);
            this.dataGridView1.DataSource = this.bindingSource1;
            path = "data/test.csv";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //press btn load to load the file 
        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog();
            table = Readcsv.Read_csv("data/test.csv");
            bindingSource1.DataSource = table;
        }

        //press btn export to save the file 
        private void button3_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                //SavefileDialog();
                Savecsv sa = new Savecsv();
                sa.SaveDataTableAsCsv(table, path);
                MessageBox.Show("Saved");
            }
        }

        //let the user to search with their selected condition 
        private void button4_Click(object sender, EventArgs e)
        {
            SearchFilter();
        }

        //let the user to delete the record from the file 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.table.DefaultView.RowFilter = "";
        }


        public void btnEdit_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                //this.bindingSource1.ResetBindings(false);
                FormEdit fe = new FormEdit(table, dataGridView1.CurrentRow);
                fe.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                FormAdminAdd fa = new FormAdminAdd(table, path);
                fa.Show();
                

            }
        }


        private void btnReflesh_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                table = Readcsv.Read_csv(path);
                bindingSource1.DataSource = table;
            }

        }


        /// <summary>
        /// Function Section
        /// </summary>




        public void OpenFileDialog()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "OPEN FILE";
            op.InitialDirectory = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            op.FileName = null;
            op.Filter = "CSV file(*.csv)|*.csv";
            op.FilterIndex = 1;
            
            DialogResult result = op.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = op.FileName;

                table =
                    Readcsv.Read_csv(path);


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
                    table = Readcsv.Read_csv(sa.FileName);

                    
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
        public void DeleteRecord()
        {
            if (dataGridView1.SelectedRows != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure？", "Comfirmation", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("Select the row you want to delete");
            }
        }





}
}



