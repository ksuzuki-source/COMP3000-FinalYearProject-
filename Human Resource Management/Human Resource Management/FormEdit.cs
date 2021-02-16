using System;
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
        FormViewData fvd = new FormViewData();
        public FormEdit(DataGridViewRow gdvr)
        {
            InitializeComponent();

            currentRow = gdvr;
        }

        private DataGridViewRow currentRow = new DataGridViewRow();

        private void FormEdit_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(currentRow.Cells[0].Value);
            string originalName, originalSex, originalRole, originalPassword, originalPostcode, originalAge;

            originalName = (string)currentRow.Cells[0].Value;
            originalSex = (string)currentRow.Cells[1].Value;
            originalRole = (string)currentRow.Cells[2].Value;
            originalPassword = (string)currentRow.Cells[3].Value;
            originalPostcode = (string)currentRow.Cells[4].Value;
            originalAge = (string)currentRow.Cells[5].Value;

            textBox1.Text = originalName;
            textBox2.Text = originalSex;
            textBox3.Text = originalRole;
            textBox4.Text = originalPassword;
            textBox5.Text = originalPostcode;
            textBox6.Text = originalAge;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (currentRow != null)
            {
                currentRow.Cells[0].Value = (object)textBox1.Text;
                currentRow.Cells[1].Value = (object)textBox2.Text;
                currentRow.Cells[2].Value = (object)textBox3.Text;
                currentRow.Cells[3].Value = (object)textBox4.Text;
                currentRow.Cells[4].Value = (object)textBox5.Text;
                currentRow.Cells[5].Value = (object)textBox6.Text;

                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
