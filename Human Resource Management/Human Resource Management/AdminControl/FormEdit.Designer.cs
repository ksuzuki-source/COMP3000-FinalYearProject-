
namespace Human_Resource_Management
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RoleBox2 = new System.Windows.Forms.ComboBox();
            this.SexBox1 = new System.Windows.Forms.ComboBox();
            this.S = new System.Windows.Forms.Button();
            this.btnShowBackground = new System.Windows.Forms.Button();
            this.btnWorkingRecord = new System.Windows.Forms.Button();
            this.DrivingLisence = new System.Windows.Forms.Label();
            this.txtDrivingLisence = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(85, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 28);
            this.txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(85, 454);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostcode.Location = new System.Drawing.Point(379, 184);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(284, 28);
            this.txtPostcode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Role";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(379, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Post Code";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(262, 543);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 48);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(506, 543);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 48);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(379, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of Birth(yyyy/mm/dd)";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.Location = new System.Drawing.Point(379, 295);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(284, 28);
            this.txtAge.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(144, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Edit the labour\'s data";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RoleBox2
            // 
            this.RoleBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "User"});
            this.RoleBox2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleBox2.FormattingEnabled = true;
            this.RoleBox2.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.RoleBox2.Location = new System.Drawing.Point(85, 345);
            this.RoleBox2.Name = "RoleBox2";
            this.RoleBox2.Size = new System.Drawing.Size(288, 28);
            this.RoleBox2.TabIndex = 22;
            this.RoleBox2.Text = "Select Role(User, Admin)";
            // 
            // SexBox1
            // 
            this.SexBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "M",
            "F",
            "O"});
            this.SexBox1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SexBox1.FormattingEnabled = true;
            this.SexBox1.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.SexBox1.Location = new System.Drawing.Point(85, 244);
            this.SexBox1.Name = "SexBox1";
            this.SexBox1.Size = new System.Drawing.Size(288, 28);
            this.SexBox1.TabIndex = 21;
            this.SexBox1.Text = "Select sex(Man, Female, Other)";
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.S.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S.Location = new System.Drawing.Point(726, 148);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(206, 108);
            this.S.TabIndex = 23;
            this.S.Text = "View CV";
            this.S.UseVisualStyleBackColor = false;
            this.S.Click += new System.EventHandler(this.btnShowCV_Click);
            // 
            // btnShowBackground
            // 
            this.btnShowBackground.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowBackground.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowBackground.Location = new System.Drawing.Point(726, 303);
            this.btnShowBackground.Name = "btnShowBackground";
            this.btnShowBackground.Size = new System.Drawing.Size(206, 109);
            this.btnShowBackground.TabIndex = 24;
            this.btnShowBackground.Text = "View background";
            this.btnShowBackground.UseVisualStyleBackColor = false;
            this.btnShowBackground.Click += new System.EventHandler(this.btnShowBackground_Click);
            // 
            // btnWorkingRecord
            // 
            this.btnWorkingRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWorkingRecord.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWorkingRecord.Location = new System.Drawing.Point(726, 440);
            this.btnWorkingRecord.Name = "btnWorkingRecord";
            this.btnWorkingRecord.Size = new System.Drawing.Size(206, 112);
            this.btnWorkingRecord.TabIndex = 25;
            this.btnWorkingRecord.Text = "View Working record";
            this.btnWorkingRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWorkingRecord.UseVisualStyleBackColor = false;
            this.btnWorkingRecord.Click += new System.EventHandler(this.btnWorkingRecord_Click);
            // 
            // DrivingLisence
            // 
            this.DrivingLisence.AutoSize = true;
            this.DrivingLisence.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrivingLisence.Location = new System.Drawing.Point(379, 377);
            this.DrivingLisence.Name = "DrivingLisence";
            this.DrivingLisence.Size = new System.Drawing.Size(165, 20);
            this.DrivingLisence.TabIndex = 26;
            this.DrivingLisence.Text = "DrivingLisence(Y/N)";
            // 
            // txtDrivingLisence
            // 
            this.txtDrivingLisence.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDrivingLisence.Location = new System.Drawing.Point(379, 412);
            this.txtDrivingLisence.Name = "txtDrivingLisence";
            this.txtDrivingLisence.Size = new System.Drawing.Size(294, 29);
            this.txtDrivingLisence.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(370, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Please remaind to save the work after edit the data";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 614);
            this.Controls.Add(this.txtDrivingLisence);
            this.Controls.Add(this.DrivingLisence);
            this.Controls.Add(this.btnWorkingRecord);
            this.Controls.Add(this.btnShowBackground);
            this.Controls.Add(this.S);
            this.Controls.Add(this.RoleBox2);
            this.Controls.Add(this.SexBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RoleBox2;
        private System.Windows.Forms.ComboBox SexBox1;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button btnShowBackground;
        private System.Windows.Forms.Button btnWorkingRecord;
        private System.Windows.Forms.Label DrivingLisence;
        private System.Windows.Forms.TextBox txtDrivingLisence;
        private System.Windows.Forms.Label label8;
    }
}