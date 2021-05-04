using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;

namespace Human_Resource_Management
{
    //this form is for viewing the data with CRUD  
    public partial class FormViewData : Form
    {
        //using BindingSource and datatable to make the search function more flexible
        private SqlConnection Cnn;
        private SqlCommand Cmd;
        private SqlCommand InsCmd;
        private SqlCommand UpdCmd;
        private SqlCommand DelCmd;
        private SqlDataAdapter Dta;
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
            //path = "data/test.csv";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cnn = new SqlConnection(Properties.Settings.Default.sqlServer);
            Cnn.Open();

            Cmd = new SqlCommand("SELECT * FROM worker", Cnn);
            Dta = new SqlDataAdapter(Cmd);

            InsCmd = new SqlCommand("INSERT INTO worker (Name, SEX, Role, Password, Postcode, DateofBirth, DrivingLisence) " +
                     "VALUES ( @Name, @SEX, @Role, @Password, @Postcode, @DateofBirth, @DrivingLisence)", Cnn);

            InsCmd.Parameters.Add(new SqlParameter("@ID", "ID"));
            InsCmd.Parameters.Add(new SqlParameter("@Name", "Name"));
            InsCmd.Parameters.Add(new SqlParameter("@SEX", "SEX"));
            InsCmd.Parameters.Add(new SqlParameter("@Role", "Role"));
            InsCmd.Parameters.Add(new SqlParameter("@Password", "Password"));
            InsCmd.Parameters.Add(new SqlParameter("@Postcode", "Postcode"));
            InsCmd.Parameters.Add(new SqlParameter("@DateofBirth", "DateofBirth"));
            InsCmd.Parameters.Add(new SqlParameter("@DrivingLisence", "DrivingLisence"));

            //InsCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            //InsCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
            //InsCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, "SEX");
            //InsCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, "Role");
            //InsCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, "Password");
            //InsCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, "Postcode");
            //InsCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, "DateofBirth");
            //nsCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, "DrivingLisence");




            DelCmd = new SqlCommand("DELETE FROM worker WHERE ID = @ID", Cnn);
            DelCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");

            Dta.SelectCommand = Cmd;
            Dta.InsertCommand = InsCmd;
            Dta.UpdateCommand = UpdCmd;
            Dta.DeleteCommand = DelCmd;
            table.Clear();
            Dta.Fill(table);
            bindingSource1.DataSource = table;
            Cnn.Close();
        }

        //press btn load to load the file 
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Dta.Fill(table);
            //dataGridView1.DataSource = table;
            //OpenFileDialog();
            //table = Readcsv.Read_csv("data/test.csv");
            bindingSource1.DataSource = table;
        }

        //press btn export to save the file 
        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        //let the user to search with their selected condition 
        private void btnSearch_Click(object sender, EventArgs e)
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
            if (table != null)
            {
                //this.bindingSource1.ResetBindings(false);
                FormEdit fe = new FormEdit(table, (int)dataGridView1.CurrentRow.Cells[0].Value);
                fe.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (table != null)
            {
                FormAdminAdd fa = new FormAdminAdd(table);
                fa.Show();
                

            }
        }


        private void btnReflesh_Click(object sender, EventArgs e)
        {
            if (table != null)
            {
                table.Clear();
                Dta.Fill(table);
                bindingSource1.DataSource = table;
            }

        }


        /// <summary>
        /// Function Section
        /// </summary>





        public void Update()
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                UpdCmd = new SqlCommand("UPDATE worker SET  Name = @Name, SEX = @SEX, Role = @Role," +
                    " Password = @Password, Postcode = @Postcode, DateofBirth = @DateofBirth, DrivingLisence = @DrivingLisence " +
                    "WHERE ID = @ID", Cnn);
                UpdCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
                UpdCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, "Name");
                UpdCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, "SEX");
                UpdCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, "Role");
                UpdCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, "Password");
                UpdCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, "Postcode");
                UpdCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, "DateofBirth");
                UpdCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, "DrivingLisence");
                //UpdCmd.Parameters.Add("@ID", SqlDbType.Int, 4, (int)dataGridView1.Rows[i].Cells[0].Value);
                //UpdCmd.Parameters.Add("@Name", SqlDbType.VarChar, 50, (string)dataGridView1.Rows[i].Cells[1].Value);
                //UpdCmd.Parameters.Add("@SEX", SqlDbType.Char, 10, (string)dataGridView1.Rows[i].Cells[2].Value);
                //UpdCmd.Parameters.Add("@Role", SqlDbType.VarChar, 50, (string)dataGridView1.Rows[i].Cells[3].Value);
                //UpdCmd.Parameters.Add("@Password", SqlDbType.VarChar, 50, (string)dataGridView1.Rows[i].Cells[4].Value);
                //UpdCmd.Parameters.Add("@Postcode", SqlDbType.Char, 10, (string)dataGridView1.Rows[i].Cells[5].Value);
                //UpdCmd.Parameters.Add("@DateofBirth", SqlDbType.Date, 3, (string)dataGridView1.Rows[i].Cells[6].Value);
                //UpdCmd.Parameters.Add("@DrivingLisence", SqlDbType.Char, 1, (string)dataGridView1.Rows[i].Cells[7].Value);
            }
            Dta.UpdateCommand = UpdCmd;

            Dta.Update(table);
            table.Clear();
            Dta.Fill(table);

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
                    Dta.Update(table);
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



