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
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 266);
            this.Controls.Add(this.BTN_Ok);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ok;
    }
}