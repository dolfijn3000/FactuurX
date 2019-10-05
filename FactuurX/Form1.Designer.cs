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
            this.opslaanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.TAB_Preview = new System.Windows.Forms.TabPage();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.WB_Preview = new System.Windows.Forms.WebBrowser();
            this.TXT_btwNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Municipality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Street = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TAB_Main.SuspendLayout();
            this.TABP_General.SuspendLayout();
            this.TABP_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.TAB_Preview.SuspendLayout();
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            this.opslaanToolStripMenuItem.Click += new System.EventHandler(this.opslaanToolStripMenuItem_Click);
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
            this.exporteerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exporteerToolStripMenuItem.Text = "exporteer";
            this.exporteerToolStripMenuItem.Click += new System.EventHandler(this.exporteerToolStripMenuItem_Click);
            // 
            // profielToolStripMenuItem
            // 
            this.profielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem1,
            this.selecteerToolStripMenuItem,
            this.opslaanToolStripMenuItem1,
            this.itemsToolStripMenuItem,
            this.klantenToolStripMenuItem});
            this.profielToolStripMenuItem.Name = "profielToolStripMenuItem";
            this.profielToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profielToolStripMenuItem.Text = "Profiel";
            // 
            // nieuwToolStripMenuItem1
            // 
            this.nieuwToolStripMenuItem1.Name = "nieuwToolStripMenuItem1";
            this.nieuwToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.nieuwToolStripMenuItem1.Text = "nieuw";
            this.nieuwToolStripMenuItem1.Click += new System.EventHandler(this.NieuwToolStripMenuItem1_Click);
            // 
            // selecteerToolStripMenuItem
            // 
            this.selecteerToolStripMenuItem.Name = "selecteerToolStripMenuItem";
            this.selecteerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.selecteerToolStripMenuItem.Text = "open";
            this.selecteerToolStripMenuItem.Click += new System.EventHandler(this.selecteerToolStripMenuItem_Click);
            // 
            // opslaanToolStripMenuItem1
            // 
            this.opslaanToolStripMenuItem1.Name = "opslaanToolStripMenuItem1";
            this.opslaanToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.opslaanToolStripMenuItem1.Text = "opslaan";
            this.opslaanToolStripMenuItem1.Click += new System.EventHandler(this.opslaanToolStripMenuItem1_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.itemsToolStripMenuItem.Text = "items";
            // 
            // klantenToolStripMenuItem
            // 
            this.klantenToolStripMenuItem.Name = "klantenToolStripMenuItem";
            this.klantenToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.klantenToolStripMenuItem.Text = "klanten";
            // 
            // TAB_Main
            // 
            this.TAB_Main.Controls.Add(this.TABP_General);
            this.TAB_Main.Controls.Add(this.TABP_Items);
            this.TAB_Main.Controls.Add(this.TAB_Preview);
            this.TAB_Main.Location = new System.Drawing.Point(13, 28);
            this.TAB_Main.Name = "TAB_Main";
            this.TAB_Main.SelectedIndex = 0;
            this.TAB_Main.Size = new System.Drawing.Size(1422, 533);
            this.TAB_Main.TabIndex = 3;
            // 
            // TABP_General
            // 
            this.TABP_General.Controls.Add(this.TXT_btwNumber);
            this.TABP_General.Controls.Add(this.label4);
            this.TABP_General.Controls.Add(this.TXT_Municipality);
            this.TABP_General.Controls.Add(this.label5);
            this.TABP_General.Controls.Add(this.TXT_Street);
            this.TABP_General.Controls.Add(this.label6);
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
            this.TXT_CustomerName.Size = new System.Drawing.Size(564, 20);
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
            this.TABP_Items.Controls.Add(this.DGV_Items);
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Voeg item toe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DGV_Items
            // 
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Location = new System.Drawing.Point(4, 73);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.Size = new System.Drawing.Size(1404, 428);
            this.DGV_Items.TabIndex = 0;
            this.DGV_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // TAB_Preview
            // 
            this.TAB_Preview.Controls.Add(this.BTN_Generate);
            this.TAB_Preview.Controls.Add(this.WB_Preview);
            this.TAB_Preview.Location = new System.Drawing.Point(4, 22);
            this.TAB_Preview.Name = "TAB_Preview";
            this.TAB_Preview.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Preview.Size = new System.Drawing.Size(1414, 507);
            this.TAB_Preview.TabIndex = 2;
            this.TAB_Preview.Text = "factuur";
            this.TAB_Preview.UseVisualStyleBackColor = true;
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Location = new System.Drawing.Point(3, 6);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Generate.TabIndex = 1;
            this.BTN_Generate.Text = "generate";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // WB_Preview
            // 
            this.WB_Preview.Location = new System.Drawing.Point(6, 35);
            this.WB_Preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_Preview.Name = "WB_Preview";
            this.WB_Preview.Size = new System.Drawing.Size(1402, 466);
            this.WB_Preview.TabIndex = 0;
            this.WB_Preview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB_Preview_DocumentCompleted);
            // 
            // TXT_btwNumber
            // 
            this.TXT_btwNumber.Location = new System.Drawing.Point(85, 131);
            this.TXT_btwNumber.Name = "TXT_btwNumber";
            this.TXT_btwNumber.ReadOnly = true;
            this.TXT_btwNumber.Size = new System.Drawing.Size(525, 20);
            this.TXT_btwNumber.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "BTW nummer";
            // 
            // TXT_Municipality
            // 
            this.TXT_Municipality.Location = new System.Drawing.Point(64, 105);
            this.TXT_Municipality.Name = "TXT_Municipality";
            this.TXT_Municipality.ReadOnly = true;
            this.TXT_Municipality.Size = new System.Drawing.Size(546, 20);
            this.TXT_Municipality.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "gemeente";
            // 
            // TXT_Street
            // 
            this.TXT_Street.Location = new System.Drawing.Point(46, 79);
            this.TXT_Street.Name = "TXT_Street";
            this.TXT_Street.ReadOnly = true;
            this.TXT_Street.Size = new System.Drawing.Size(564, 20);
            this.TXT_Street.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "straat";
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.TAB_Preview.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView DGV_Items;
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
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem1;
        private System.Windows.Forms.TabPage TAB_Preview;
        private System.Windows.Forms.WebBrowser WB_Preview;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.TextBox TXT_btwNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Municipality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Street;
        private System.Windows.Forms.Label label6;
    }
}

