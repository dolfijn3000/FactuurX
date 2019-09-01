namespace FactuurX
{
    partial class CustomerSelect
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
            this.LB_Customers = new System.Windows.Forms.ListBox();
            this.TXT_Search = new System.Windows.Forms.TextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Customers
            // 
            this.LB_Customers.FormattingEnabled = true;
            this.LB_Customers.Location = new System.Drawing.Point(12, 47);
            this.LB_Customers.Name = "LB_Customers";
            this.LB_Customers.Size = new System.Drawing.Size(213, 342);
            this.LB_Customers.TabIndex = 0;
            // 
            // TXT_Search
            // 
            this.TXT_Search.Location = new System.Drawing.Point(12, 21);
            this.TXT_Search.Name = "TXT_Search";
            this.TXT_Search.Size = new System.Drawing.Size(213, 20);
            this.TXT_Search.TabIndex = 1;
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(231, 21);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(75, 23);
            this.BTN_Search.TabIndex = 2;
            this.BTN_Search.Text = "zoek";
            this.BTN_Search.UseVisualStyleBackColor = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(373, 366);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "OK";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // CustomerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 401);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.TXT_Search);
            this.Controls.Add(this.LB_Customers);
            this.Name = "CustomerSelect";
            this.Text = "CustomerSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_Search;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_Ok;
        public System.Windows.Forms.ListBox LB_Customers;
    }
}