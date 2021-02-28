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
        public DataTable table;
        private DataGridViewRow currentRow = new DataGridViewRow();
        public int i;
        public string path;


        //FormViewData fvd = new FormViewData(table);
        public FormEdit(DataTable rcvtable, DataGridViewRow dgvr)
        {
            InitializeComponent();
            table = rcvtable;
            currentRow = dgvr;
        }

        

        private void FormEdit_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add(currentRow.Cells[0].Value);
            string originalName, originalSex, originalRole, originalPassword, originalPostcode, originalAge;

            originalName = (string)currentRow.Cells[0].Value;
            originalSex = (string)currentRow.Cells[1].Value;
            originalRole = (string)currentRow.Cells[2].Value;
            originalPassword = (string)currentRow.Cells[3].Value;
            originalPostcode = (string)currentRow.Cells[4].Value;
            originalAge = (string)currentRow.Cells[5].Value;

            textBox1.Text = originalName;
            SexBox1.Text = originalSex;
            RoleBox2.Text = originalRole;
            textBox4.Text = originalPassword;
            textBox5.Text = originalPostcode;
            textBox6.Text = originalAge;

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void Edit()
        {
            for (i = 0; i < table.Rows.Count; i++)
            {

                if ((((string)table.Rows[i][0] == (string)currentRow.Cells[0].Value) && ((string)table.Rows[i][3] == (string)currentRow.Cells[3].Value))
                    || ((string)table.Rows[i][0] == (string)currentRow.Cells[0].Value) && ((string)table.Rows[i][3] == (string)currentRow.Cells[4].Value))
                {
                    if (textBox1.Text != null && (SexBox1.Text == "M" || SexBox1.Text == "F" || SexBox1.Text == "O")           //check the input values
                    && (RoleBox2.Text == "User" || RoleBox2.Text == "Admin")
                    && textBox4.Text != null
                    && textBox5.Text != null
                    && textBox6.Text != null)
                    {
                        table.Rows[i][0] = textBox1.Text;
                        table.Rows[i][1] = SexBox1.Text;
                        table.Rows[i][2] = RoleBox2.Text;
                        table.Rows[i][3] = textBox4.Text;
                        table.Rows[i][4] = textBox5.Text;
                        table.Rows[i][5] = textBox6.Text;
                    }
                    else
                    {
                        MessageBox.Show("Invalid value is found");
                    }
                }
                else
                {
                    continue;
                }
            }


            MessageBox.Show("Edited");
            //Savecsv sa = new Savecsv();
            //sa.SaveDataTableAsCsv(table, path);
            FormViewData fvd = new FormViewData(table);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (i = 0; i < table.Rows.Count; i++)
            {
                if ((((string)table.Rows[i][0] == (string)currentRow.Cells[0].Value) && ((string)table.Rows[i][3] == (string)currentRow.Cells[3].Value))
                    || ((string)table.Rows[i][0] == (string)currentRow.Cells[0].Value) && ((string)table.Rows[i][3] == (string)currentRow.Cells[4].Value))
                {
                    DialogResult dr = MessageBox.Show(
                        "Record of" + table.Rows[i][0] + "will be deleted." + Environment.NewLine + "Are you sure?", "Comfirmation", MessageBoxButtons.YesNo);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        table.Rows.Remove(table.Rows[i]);
                    }
                }
            }
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
