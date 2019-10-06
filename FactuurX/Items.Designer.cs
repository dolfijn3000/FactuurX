namespace FactuurX
{
    partial class Items
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
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_referenceNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Items = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Unit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.BTN_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(326, 23);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.ReadOnly = true;
            this.TXT_Name.Size = new System.Drawing.Size(319, 20);
            this.TXT_Name.TabIndex = 1;
            // 
            // TXT_referenceNumber
            // 
            this.TXT_referenceNumber.Location = new System.Drawing.Point(382, 52);
            this.TXT_referenceNumber.Name = "TXT_referenceNumber";
            this.TXT_referenceNumber.ReadOnly = true;
            this.TXT_referenceNumber.Size = new System.Drawing.Size(263, 20);
            this.TXT_referenceNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "referentie nummer";
            // 
            // TXT_Price
            // 
            this.TXT_Price.Location = new System.Drawing.Point(326, 78);
            this.TXT_Price.Name = "TXT_Price";
            this.TXT_Price.ReadOnly = true;
            this.TXT_Price.Size = new System.Drawing.Size(319, 20);
            this.TXT_Price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "prijs";
            // 
            // LB_Items
            // 
            this.LB_Items.FormattingEnabled = true;
            this.LB_Items.Location = new System.Drawing.Point(12, 49);
            this.LB_Items.Name = "LB_Items";
            this.LB_Items.Size = new System.Drawing.Size(186, 329);
            this.LB_Items.TabIndex = 6;
            this.LB_Items.SelectedIndexChanged += new System.EventHandler(this.LB_Items_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(205, 23);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(75, 23);
            this.BTN_Search.TabIndex = 9;
            this.BTN_Search.Text = "zoek";
            this.BTN_Search.UseVisualStyleBackColor = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Enabled = false;
            this.BTN_Add.Location = new System.Drawing.Point(579, 355);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 10;
            this.BTN_Add.Text = "Voeg toe";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(205, 355);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 11;
            this.BTN_Delete.Text = "Verwijder";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aantal:";
            // 
            // TXT_Unit
            // 
            this.TXT_Unit.Location = new System.Drawing.Point(340, 104);
            this.TXT_Unit.Name = "TXT_Unit";
            this.TXT_Unit.ReadOnly = true;
            this.TXT_Unit.Size = new System.Drawing.Size(305, 20);
            this.TXT_Unit.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Eenheid:";
            // 
            // NUD_Amount
            // 
            this.NUD_Amount.Location = new System.Drawing.Point(331, 130);
            this.NUD_Amount.Name = "NUD_Amount";
            this.NUD_Amount.Size = new System.Drawing.Size(120, 20);
            this.NUD_Amount.TabIndex = 16;
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(286, 355);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Edit.TabIndex = 17;
            this.BTN_Edit.Text = "bewerk";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 390);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.NUD_Amount);
            this.Controls.Add(this.TXT_Unit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB_Items);
            this.Controls.Add(this.TXT_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_referenceNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.label1);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.TextBox TXT_referenceNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Delete;
        public System.Windows.Forms.ListBox LB_Items;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUD_Amount;
        private System.Windows.Forms.Button BTN_Edit;
    }
}