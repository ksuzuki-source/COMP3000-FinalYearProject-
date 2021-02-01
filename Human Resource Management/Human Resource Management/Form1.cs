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
            this.DataLoad();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ExportFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
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

                TextFieldParser parser = new TextFieldParser(op.FileName);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(","); // 区切り文字はコンマ

                dataGridView1.Rows.Clear();

                while (!parser.EndOfData)
                {
                    string[] row = parser.ReadFields(); 
                                                        
                    dataGridView1.Rows.Add(row);
                }
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


    }
}

    
