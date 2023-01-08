
namespace BillingApp
{
    partial class BillSearch
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
            this.FolderLB = new System.Windows.Forms.ListBox();
            this.FileLB = new System.Windows.Forms.ListBox();
            this.BillPviewLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FolderLB
            // 
            this.FolderLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderLB.FormattingEnabled = true;
            this.FolderLB.ItemHeight = 20;
            this.FolderLB.Location = new System.Drawing.Point(12, 42);
            this.FolderLB.Name = "FolderLB";
            this.FolderLB.ScrollAlwaysVisible = true;
            this.FolderLB.Size = new System.Drawing.Size(155, 124);
            this.FolderLB.TabIndex = 1;
            this.FolderLB.SelectedIndexChanged += new System.EventHandler(this.FolderLB_SelectedIndexChanged);
            // 
            // FileLB
            // 
            this.FileLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLB.FormattingEnabled = true;
            this.FileLB.ItemHeight = 20;
            this.FileLB.Location = new System.Drawing.Point(12, 230);
            this.FileLB.Name = "FileLB";
            this.FileLB.ScrollAlwaysVisible = true;
            this.FileLB.Size = new System.Drawing.Size(155, 124);
            this.FileLB.TabIndex = 2;
            this.FileLB.SelectedIndexChanged += new System.EventHandler(this.FileLB_SelectedIndexChanged);
            // 
            // BillPviewLB
            // 
            this.BillPviewLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillPviewLB.FormattingEnabled = true;
            this.BillPviewLB.ItemHeight = 18;
            this.BillPviewLB.Items.AddRange(new object[] {
            "ProductID\t\tProduct \t\tQty\tUnit Cost \t\tCost"});
            this.BillPviewLB.Location = new System.Drawing.Point(232, 12);
            this.BillPviewLB.Name = "BillPviewLB";
            this.BillPviewLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.BillPviewLB.Size = new System.Drawing.Size(556, 418);
            this.BillPviewLB.TabIndex = 4;
            // 
            // BillSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BillPviewLB);
            this.Controls.Add(this.FileLB);
            this.Controls.Add(this.FolderLB);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "BillSearch";
            this.Text = "BillSearch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FolderLB;
        private System.Windows.Forms.ListBox FileLB;
        private System.Windows.Forms.ListBox BillPviewLB;
    }
}