
namespace Human_Resource_Management
{
    partial class FormUserEdit
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
            this.txtDrivingLisence = new System.Windows.Forms.TextBox();
            this.DrivingLisence = new System.Windows.Forms.Label();
            this.btnWorkingRecord = new System.Windows.Forms.Button();
            this.btnShowBackground = new System.Windows.Forms.Button();
            this.RoleBox2 = new System.Windows.Forms.ComboBox();
            this.SexBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDrivingLisence
            // 
            this.txtDrivingLisence.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDrivingLisence.Location = new System.Drawing.Point(393, 404);
            this.txtDrivingLisence.Name = "txtDrivingLisence";
            this.txtDrivingLisence.Size = new System.Drawing.Size(294, 29);
            this.txtDrivingLisence.TabIndex = 48;
            // 
            // DrivingLisence
            // 
            this.DrivingLisence.AutoSize = true;
            this.DrivingLisence.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrivingLisence.Location = new System.Drawing.Point(393, 369);
            this.DrivingLisence.Name = "DrivingLisence";
            this.DrivingLisence.Size = new System.Drawing.Size(165, 20);
            this.DrivingLisence.TabIndex = 47;
            this.DrivingLisence.Text = "DrivingLisence(Y/N)";
            // 
            // btnWorkingRecord
            // 
            this.btnWorkingRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWorkingRecord.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWorkingRecord.Location = new System.Drawing.Point(740, 380);
            this.btnWorkingRecord.Name = "btnWorkingRecord";
            this.btnWorkingRecord.Size = new System.Drawing.Size(206, 112);
            this.btnWorkingRecord.TabIndex = 46;
            this.btnWorkingRecord.Text = "View Working record";
            this.btnWorkingRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWorkingRecord.UseVisualStyleBackColor = false;
            this.btnWorkingRecord.Click += new System.EventHandler(this.btnWorkingRecord_Click);
            // 
            // btnShowBackground
            // 
            this.btnShowBackground.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowBackground.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowBackground.Location = new System.Drawing.Point(740, 184);
            this.btnShowBackground.Name = "btnShowBackground";
            this.btnShowBackground.Size = new System.Drawing.Size(206, 109);
            this.btnShowBackground.TabIndex = 45;
            this.btnShowBackground.Text = "View background";
            this.btnShowBackground.UseVisualStyleBackColor = false;
            this.btnShowBackground.Click += new System.EventHandler(this.btnShowBackground_Click);
            // 
            // RoleBox2
            // 
            this.RoleBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "User"});
            this.RoleBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.RoleBox2.Enabled = false;
            this.RoleBox2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleBox2.FormattingEnabled = true;
            this.RoleBox2.Location = new System.Drawing.Point(99, 337);
            this.RoleBox2.Name = "RoleBox2";
            this.RoleBox2.Size = new System.Drawing.Size(288, 28);
            this.RoleBox2.TabIndex = 43;
            this.RoleBox2.SelectedIndexChanged += new System.EventHandler(this.RoleBox2_SelectedIndexChanged);
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
            this.SexBox1.Location = new System.Drawing.Point(99, 236);
            this.SexBox1.Name = "SexBox1";
            this.SexBox1.Size = new System.Drawing.Size(288, 28);
            this.SexBox1.TabIndex = 42;
            this.SexBox1.Text = "Select sex(Man, Female, Other)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(384, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 26);
            this.label8.TabIndex = 41;
            this.label8.Text = "Please remaind to save the work after edit the data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(158, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 26);
            this.label7.TabIndex = 40;
            this.label7.Text = "Edit the labour\'s data";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.Location = new System.Drawing.Point(393, 287);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(284, 28);
            this.txtAge.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(393, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date of Birth(yyyy/mm/dd)";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(520, 535);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 48);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(276, 535);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 48);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(393, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Post Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Sex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPostcode.Location = new System.Drawing.Point(393, 176);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(284, 28);
            this.txtPostcode.TabIndex = 30;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(99, 446);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 28);
            this.txtPassword.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(99, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 28);
            this.txtName.TabIndex = 28;
            // 
            // FormUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 614);
            this.Controls.Add(this.txtDrivingLisence);
            this.Controls.Add(this.DrivingLisence);
            this.Controls.Add(this.btnWorkingRecord);
            this.Controls.Add(this.btnShowBackground);
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
            this.Name = "FormUserEdit";
            this.Text = "FormUserEdit";
            this.Load += new System.EventHandler(this.FormUserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrivingLisence;
        private System.Windows.Forms.Label DrivingLisence;
        private System.Windows.Forms.Button btnWorkingRecord;
        private System.Windows.Forms.Button btnShowBackground;
        private System.Windows.Forms.ComboBox RoleBox2;
        private System.Windows.Forms.ComboBox SexBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPostcode;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtName;
    }
}