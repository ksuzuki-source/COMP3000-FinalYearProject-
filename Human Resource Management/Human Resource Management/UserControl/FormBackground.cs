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
    public partial class FormBackground : Form
    {
        string path;
        public FormBackground(string rcvpath)
        {
            InitializeComponent();
            path = ("data/Details/Other/" + rcvpath + ".txt");
        }

        private void FormLabourDetails_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    textBox1.Text += (line + "\r\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                for (int i = 0; i < textBox1.Lines.Length; i++)
                {
                    sr.WriteLine(textBox1.Lines[i]);
                }
            }
            MessageBox.Show("Saved");
        }
    }
}