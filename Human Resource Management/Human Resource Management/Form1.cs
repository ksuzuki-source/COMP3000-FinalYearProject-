using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Human_Resource_Management
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.DataLoad();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ExportFile();
        }



        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        /// 
        string FileName = null;

        public void DataLoad()
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
                string fileName = op.FileName;

                string[] csvDataAll = File.ReadAllLines(op.FileName, Encoding.Default);

                DataGridViewRow[] rows = new DataGridViewRow[csvDataAll.Length];

                for (int i = 0; i < csvDataAll.Length; i++)
                {
                    string[] csv = csvDataAll[i].Split(',');
                    string[] data = new string[9];
                    Array.Copy(csv, 0, data, 0, 3);

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.dataGridView1);
                    row.SetValues(data);
                    rows[i] = row;
                }

                this.dataGridView1.Rows.AddRange(rows);

                FileName = op.FileName;
            }
            else if (result == DialogResult.Cancel)
            {
            }     
        }
        

        public void SaveFile()
        {
            if (FileName != null)
            {
                using (StreamWriter writer = new StreamWriter(FileName))
                {

                    int rowCount = dataGridView1.Rows.Count;


                    if (dataGridView1.AllowUserToAddRows == true)
                    {
                        rowCount = rowCount - 1;
                    }

                    for (int i = 0; i < rowCount; i++)
                    {

                        List<String> strList = new List<String>();


                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            strList.Add(dataGridView1[j, i].Value.ToString());
                        }
                        String[] strArray = strList.ToArray();


                        String strCsvData = String.Join(",", strArray);

                        writer.WriteLine(strCsvData);
                    }
                }
            }
            else
            { }
        }
        public void ExportFile()
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "SAVE FILE";
            sa.InitialDirectory = @"C:\";
            sa.FileName = FileName;
            sa.Filter = "CSV file(*.csv)|*.csv";
            sa.FilterIndex = 1;

            DialogResult result = sa.ShowDialog();

            if (result == DialogResult.OK)
            {

                string fileName = FileName;

                using (StreamWriter writer = new StreamWriter(FileName))
                {

                    int rowCount = dataGridView1.Rows.Count;


                    if (dataGridView1.AllowUserToAddRows == true)
                    {
                        rowCount = rowCount - 1;
                    }

                    for (int i = 0; i < rowCount; i++)
                    {

                        List<String> strList = new List<String>();


                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            strList.Add(dataGridView1[j, i].Value.ToString());
                        }
                        String[] strArray = strList.ToArray();


                        String strCsvData = String.Join(",", strArray);

                        writer.WriteLine(strCsvData);
                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}

    
