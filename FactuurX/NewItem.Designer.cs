namespace FactuurX
{
    partial class NewItem
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
            this.TXT_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_referenceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.TXT_Unit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Price
            // 
            this.TXT_Price.Location = new System.Drawing.Point(55, 67);
            this.TXT_Price.Name = "TXT_Price";
            this.TXT_Price.Size = new System.Drawing.Size(263, 20);
            this.TXT_Price.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "prijs";
            // 
            // TXT_referenceNumber
            // 
            this.TXT_referenceNumber.Location = new System.Drawing.Point(111, 41);
            this.TXT_referenceNumber.Name = "TXT_referenceNumber";
            this.TXT_referenceNumber.Size = new System.Drawing.Size(207, 20);
            this.TXT_referenceNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "referentie nummer";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(55, 12);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(263, 20);
            this.TXT_Name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(378, 148);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 12;
            this.BTN_Ok.Text = "ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // TXT_Unit
            // 
            this.TXT_Unit.Location = new System.Drawing.Point(65, 93);
            this.TXT_Unit.Name = "TXT_Unit";
            this.TXT_Unit.Size = new System.Drawing.Size(253, 20);
            this.TXT_Unit.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "eenheid";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 183);
            this.Controls.Add(this.TXT_Unit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.TXT_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_referenceNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.label1);
            this.Name = "NewItem";
            this.Text = "NewItem";
            this.Load += new System.EventHandler(this.NewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TXT_Price;
        public System.Windows.Forms.TextBox TXT_referenceNumber;
        public System.Windows.Forms.TextBox TXT_Name;
        public System.Windows.Forms.TextBox TXT_Unit;
    }
}