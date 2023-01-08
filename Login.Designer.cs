
namespace SimpleBillingApp
{
    partial class Login
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
            this.EmpPhNumber = new System.Windows.Forms.TextBox();
            this.EmpLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpPhNumber
            // 
            this.EmpPhNumber.Location = new System.Drawing.Point(337, 161);
            this.EmpPhNumber.Name = "EmpPhNumber";
            this.EmpPhNumber.Size = new System.Drawing.Size(100, 20);
            this.EmpPhNumber.TabIndex = 0;
            // 
            // EmpLable
            // 
            this.EmpLable.AutoSize = true;
            this.EmpLable.Location = new System.Drawing.Point(242, 167);
            this.EmpLable.Name = "EmpLable";
            this.EmpLable.Size = new System.Drawing.Size(90, 13);
            this.EmpLable.TabIndex = 1;
            this.EmpLable.Text = "Employee Phone:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmpLable);
            this.Controls.Add(this.EmpPhNumber);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpPhNumber;
        private System.Windows.Forms.Label EmpLable;
        private System.Windows.Forms.Button button1;
    }
}

