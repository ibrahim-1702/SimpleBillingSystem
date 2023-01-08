
namespace SimpleBillingApp
{
    partial class Billing
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
            this.ProductsLB = new System.Windows.Forms.ListBox();
            this.QtyUpDwn = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.BillPviewLB = new System.Windows.Forms.ListBox();
            this.BillBT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BillSearchBT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QtyUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsLB
            // 
            this.ProductsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLB.FormattingEnabled = true;
            this.ProductsLB.ItemHeight = 20;
            this.ProductsLB.Location = new System.Drawing.Point(12, 71);
            this.ProductsLB.Name = "ProductsLB";
            this.ProductsLB.ScrollAlwaysVisible = true;
            this.ProductsLB.Size = new System.Drawing.Size(155, 124);
            this.ProductsLB.TabIndex = 0;
            this.ProductsLB.SelectedIndexChanged += new System.EventHandler(this.ProductsLB_SelectedIndexChanged);
            // 
            // QtyUpDwn
            // 
            this.QtyUpDwn.Location = new System.Drawing.Point(173, 133);
            this.QtyUpDwn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QtyUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QtyUpDwn.Name = "QtyUpDwn";
            this.QtyUpDwn.Size = new System.Drawing.Size(54, 20);
            this.QtyUpDwn.TabIndex = 1;
            this.QtyUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(173, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillPviewLB
            // 
            this.BillPviewLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillPviewLB.FormattingEnabled = true;
            this.BillPviewLB.ItemHeight = 18;
            this.BillPviewLB.Items.AddRange(new object[] {
            "ProductID\t\tProduct \t\tQty\tUnit Cost \t\tCost"});
            this.BillPviewLB.Location = new System.Drawing.Point(335, 71);
            this.BillPviewLB.Name = "BillPviewLB";
            this.BillPviewLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.BillPviewLB.Size = new System.Drawing.Size(556, 328);
            this.BillPviewLB.TabIndex = 3;
            // 
            // BillBT
            // 
            this.BillBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BillBT.Location = new System.Drawing.Point(243, 260);
            this.BillBT.Name = "BillBT";
            this.BillBT.Size = new System.Drawing.Size(75, 42);
            this.BillBT.TabIndex = 4;
            this.BillBT.Text = "BILL";
            this.BillBT.UseVisualStyleBackColor = true;
            this.BillBT.Click += new System.EventHandler(this.BillBT_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(11, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(128, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BillSearchBT
            // 
            this.BillSearchBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BillSearchBT.Location = new System.Drawing.Point(11, 357);
            this.BillSearchBT.Name = "BillSearchBT";
            this.BillSearchBT.Size = new System.Drawing.Size(146, 42);
            this.BillSearchBT.TabIndex = 7;
            this.BillSearchBT.Text = "Bill Records";
            this.BillSearchBT.UseVisualStyleBackColor = true;
            this.BillSearchBT.Click += new System.EventHandler(this.BillSearchBT_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(173, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Add New Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BillSearchBT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BillBT);
            this.Controls.Add(this.BillPviewLB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QtyUpDwn);
            this.Controls.Add(this.ProductsLB);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QtyUpDwn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsLB;
        private System.Windows.Forms.NumericUpDown QtyUpDwn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox BillPviewLB;
        private System.Windows.Forms.Button BillBT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BillSearchBT;
        private System.Windows.Forms.Button button4;
    }
}