namespace FactuurX
{
    partial class NewCustomer
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_Street = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Municipality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_btwNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(580, 231);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 0;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "naam:";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(55, 10);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(564, 20);
            this.TXT_Name.TabIndex = 2;
            // 
            // TXT_Street
            // 
            this.TXT_Street.Location = new System.Drawing.Point(55, 36);
            this.TXT_Street.Name = "TXT_Street";
            this.TXT_Street.Size = new System.Drawing.Size(564, 20);
            this.TXT_Street.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "straat";
            // 
            // TXT_Municipality
            // 
            this.TXT_Municipality.Location = new System.Drawing.Point(73, 62);
            this.TXT_Municipality.Name = "TXT_Municipality";
            this.TXT_Municipality.Size = new System.Drawing.Size(546, 20);
            this.TXT_Municipality.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "gemeente";
            // 
            // TXT_btwNumber
            // 
            this.TXT_btwNumber.Location = new System.Drawing.Point(94, 88);
            this.TXT_btwNumber.Name = "TXT_btwNumber";
            this.TXT_btwNumber.Size = new System.Drawing.Size(525, 20);
            this.TXT_btwNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BTW nummert";
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 266);
            this.Controls.Add(this.TXT_btwNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Municipality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_Street);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ok);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.TextBox TXT_Street;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Municipality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_btwNumber;
        private System.Windows.Forms.Label label4;
    }
}