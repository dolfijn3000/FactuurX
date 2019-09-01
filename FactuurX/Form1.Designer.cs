namespace FactuurX
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selecteerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TAB_Main = new System.Windows.Forms.TabControl();
            this.TABP_General = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TABP_Items = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.TAB_Main.SuspendLayout();
            this.TABP_General.SuspendLayout();
            this.TABP_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1299, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1344, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROTOTYPE 0.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.bestandToolStripMenuItem1,
            this.profielToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1447, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.openToolStripMenuItem,
            this.opslaanToolStripMenuItem,
            this.instellingenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bestandToolStripMenuItem.Text = "Start";
            this.bestandToolStripMenuItem.Click += new System.EventHandler(this.bestandToolStripMenuItem_Click);
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            // 
            // instellingenToolStripMenuItem
            // 
            this.instellingenToolStripMenuItem.Name = "instellingenToolStripMenuItem";
            this.instellingenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.instellingenToolStripMenuItem.Text = "Instellingen";
            // 
            // bestandToolStripMenuItem1
            // 
            this.bestandToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporteerToolStripMenuItem});
            this.bestandToolStripMenuItem1.Name = "bestandToolStripMenuItem1";
            this.bestandToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem1.Text = "Bestand";
            // 
            // exporteerToolStripMenuItem
            // 
            this.exporteerToolStripMenuItem.Name = "exporteerToolStripMenuItem";
            this.exporteerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exporteerToolStripMenuItem.Text = "exporteer";
            // 
            // profielToolStripMenuItem
            // 
            this.profielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem1,
            this.selecteerToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.klantenToolStripMenuItem});
            this.profielToolStripMenuItem.Name = "profielToolStripMenuItem";
            this.profielToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profielToolStripMenuItem.Text = "Profiel";
            // 
            // nieuwToolStripMenuItem1
            // 
            this.nieuwToolStripMenuItem1.Name = "nieuwToolStripMenuItem1";
            this.nieuwToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.nieuwToolStripMenuItem1.Text = "nieuw";
            this.nieuwToolStripMenuItem1.Click += new System.EventHandler(this.NieuwToolStripMenuItem1_Click);
            // 
            // selecteerToolStripMenuItem
            // 
            this.selecteerToolStripMenuItem.Name = "selecteerToolStripMenuItem";
            this.selecteerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.selecteerToolStripMenuItem.Text = "selecteer";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.itemsToolStripMenuItem.Text = "items";
            // 
            // klantenToolStripMenuItem
            // 
            this.klantenToolStripMenuItem.Name = "klantenToolStripMenuItem";
            this.klantenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.klantenToolStripMenuItem.Text = "klanten";
            // 
            // TAB_Main
            // 
            this.TAB_Main.Controls.Add(this.TABP_General);
            this.TAB_Main.Controls.Add(this.TABP_Items);
            this.TAB_Main.Location = new System.Drawing.Point(13, 28);
            this.TAB_Main.Name = "TAB_Main";
            this.TAB_Main.SelectedIndex = 0;
            this.TAB_Main.Size = new System.Drawing.Size(1422, 533);
            this.TAB_Main.TabIndex = 3;
            // 
            // TABP_General
            // 
            this.TABP_General.Controls.Add(this.button2);
            this.TABP_General.Controls.Add(this.button1);
            this.TABP_General.Controls.Add(this.TXT_CustomerName);
            this.TABP_General.Controls.Add(this.label3);
            this.TABP_General.Location = new System.Drawing.Point(4, 22);
            this.TABP_General.Name = "TABP_General";
            this.TABP_General.Padding = new System.Windows.Forms.Padding(3);
            this.TABP_General.Size = new System.Drawing.Size(1414, 507);
            this.TABP_General.TabIndex = 0;
            this.TABP_General.Text = "Algemeen";
            this.TABP_General.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Maak nieuwe klant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Selecteer klant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_CustomerName
            // 
            this.TXT_CustomerName.Location = new System.Drawing.Point(46, 53);
            this.TXT_CustomerName.Name = "TXT_CustomerName";
            this.TXT_CustomerName.ReadOnly = true;
            this.TXT_CustomerName.Size = new System.Drawing.Size(320, 20);
            this.TXT_CustomerName.TabIndex = 1;
            this.TXT_CustomerName.TextChanged += new System.EventHandler(this.TXT_CustomerName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Klant:";
            // 
            // TABP_Items
            // 
            this.TABP_Items.Controls.Add(this.button4);
            this.TABP_Items.Controls.Add(this.button3);
            this.TABP_Items.Controls.Add(this.dataGridView1);
            this.TABP_Items.Location = new System.Drawing.Point(4, 22);
            this.TABP_Items.Name = "TABP_Items";
            this.TABP_Items.Padding = new System.Windows.Forms.Padding(3);
            this.TABP_Items.Size = new System.Drawing.Size(1414, 507);
            this.TABP_Items.TabIndex = 1;
            this.TABP_Items.Text = "Items";
            this.TABP_Items.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Maak nieuw item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Voeg item toe";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1404, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 586);
            this.Controls.Add(this.TAB_Main);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Factuur X";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TAB_Main.ResumeLayout(false);
            this.TABP_General.ResumeLayout(false);
            this.TABP_General.PerformLayout();
            this.TABP_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instellingenToolStripMenuItem;
        private System.Windows.Forms.TabControl TAB_Main;
        private System.Windows.Forms.TabPage TABP_General;
        private System.Windows.Forms.TabPage TABP_Items;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exporteerToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXT_CustomerName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem profielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selecteerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem;
    }
}

