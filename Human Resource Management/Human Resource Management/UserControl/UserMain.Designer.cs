
namespace Human_Resource_Management.UserControl
{
    partial class UserMain
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
            this.btnWTR = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnRate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWTR
            // 
            this.btnWTR.Location = new System.Drawing.Point(52, 235);
            this.btnWTR.Name = "btnWTR";
            this.btnWTR.Size = new System.Drawing.Size(189, 120);
            this.btnWTR.TabIndex = 0;
            this.btnWTR.Text = "Working Time Recorder";
            this.btnWTR.UseVisualStyleBackColor = true;
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(293, 235);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(182, 120);
            this.btnCV.TabIndex = 1;
            this.btnCV.Text = "View/Edit your CV";
            this.btnCV.UseVisualStyleBackColor = true;
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(532, 235);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(192, 120);
            this.btnRate.TabIndex = 2;
            this.btnRate.Text = "View your rating";
            this.btnRate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "This is main page for user!";
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.btnWTR);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWTR;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Label label1;
    }
}