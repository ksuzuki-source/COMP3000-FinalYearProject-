
namespace Human_Resource_Management
{
    partial class FormUserMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnWTR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "This is main page for user!";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(544, 238);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(192, 120);
            this.btnDetail.TabIndex = 10;
            this.btnDetail.Text = "View/Edit your Details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(305, 238);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(182, 120);
            this.btnCV.TabIndex = 9;
            this.btnCV.Text = "View/Edit your CV";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnWTR
            // 
            this.btnWTR.Location = new System.Drawing.Point(64, 238);
            this.btnWTR.Name = "btnWTR";
            this.btnWTR.Size = new System.Drawing.Size(189, 120);
            this.btnWTR.TabIndex = 8;
            this.btnWTR.Text = "Working Time Recorder";
            this.btnWTR.UseVisualStyleBackColor = true;
            this.btnWTR.Click += new System.EventHandler(this.btnWTR_Click);
            // 
            // FormUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.btnWTR);
            this.Name = "FormUserMain";
            this.Text = "FormUserMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnWTR;
    }
}