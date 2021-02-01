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
    public partial class Form2 : Form
    {
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    read_csv(op.FileName);


                this.bindingSource1.DataSource = this.table;

            }
            else if (result == DialogResult.Cancel)
            { }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                this.table.DefaultView.RowFilter =
                    "NAME LIKE '%" +
                    this.textBox1.Text + "%'";


                this.bindingSource1.ResetBindings(false);
            }
            else
            {
                this.table.DefaultView.RowFilter = "";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "OPEN FILE";
            sa.InitialDirectory = @"C:\";
            sa.FileName = null;
            sa.Filter = "CSV file(*.csv)|*.csv";
            sa.FilterIndex = 1;

            DialogResult result = sa.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveDataTableAsCsv(this.table, sa.FileName);
                this.table =
                read_csv(sa.FileName);


            }
            else if (result == DialogResult.Cancel)
            { }
        }


        public static DataTable read_csv(string path, bool header = true, char separator = ',')
        {

            using (TextFieldParser tfp =
                           new TextFieldParser(path))
            {

                tfp.TextFieldType = FieldType.Delimited;


                tfp.Delimiters = new string[] { "," };


                tfp.HasFieldsEnclosedInQuotes = true;

                tfp.TrimWhiteSpace = true;

                string[] headers = tfp.ReadFields();
                int fieldCount = headers.Length;

                DataTable dt = new DataTable();
                DataRow dr;
                DataColumn dc;

                dt.Columns.Clear();

                for (int i = 0; i < fieldCount; i++)
                {
                    dc = new DataColumn(headers[i], typeof(String));
                    dt.Columns.Add(dc);
                }

                while (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    dr = dt.NewRow();
                    for (int i = 0; i < fieldCount; i++)
                    {
                        dr[headers[i]] = fields[i];
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
                
            }
        

    }



        private void SaveDataTableAsCsv(DataTable dt, string path, bool isHeaderRequired = true)
        {
            int colCount = dt.Columns.Count;
            int lastColIndex = colCount - 1;

            using (var sr = new StreamWriter(path))
            {

                if (isHeaderRequired)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        string header = dt.Columns[i].Caption;

                        sr.Write(header);
                        if (lastColIndex > i)
                        {
                            sr.Write(',');
                        }
                    }
                    sr.Write("\r\n");
                }

                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState == DataRowState.Unchanged ||
                        row.RowState == DataRowState.Added ||
                        row.RowState == DataRowState.Modified)
                    {

                        for (int i = 0; i < colCount; i++)
                        {
                            string field =
                                row[i, DataRowVersion.Current].ToString();

 

                            sr.Write(field);
                            if (lastColIndex > i)
                            {
                                sr.Write(',');
                            }

                        }
                        sr.Write("\r\n");
                    }
                }
            }
        }


    }


}


