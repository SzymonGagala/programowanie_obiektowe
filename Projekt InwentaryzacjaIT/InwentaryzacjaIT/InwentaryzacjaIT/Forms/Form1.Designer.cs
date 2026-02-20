namespace InwentaryzacjaIT.Forms
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
            btnLokalizacje = new Button();
            btnUzytkownicy = new Button();
            btnUrzadzenia = new Button();
            btnFaktury = new Button();
            btnZamknij = new Button();
            dgvLogi = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            piToolStripMenuItem = new ToolStripMenuItem();
            zamkniToolStripMenuItem = new ToolStripMenuItem();
            zamknijToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)dgvLogi).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLokalizacje
            // 
            btnLokalizacje.Location = new Point(9, 14);
            btnLokalizacje.Name = "btnLokalizacje";
            btnLokalizacje.Size = new Size(247, 93);
            btnLokalizacje.TabIndex = 0;
            btnLokalizacje.Text = "Lokalizacje";
            btnLokalizacje.UseVisualStyleBackColor = true;
            btnLokalizacje.Click += btnLokalizacje_Click;
            // 
            // btnUzytkownicy
            // 
            btnUzytkownicy.Location = new Point(9, 113);
            btnUzytkownicy.Name = "btnUzytkownicy";
            btnUzytkownicy.Size = new Size(247, 93);
            btnUzytkownicy.TabIndex = 1;
            btnUzytkownicy.Text = "Użytkownicy";
            btnUzytkownicy.UseVisualStyleBackColor = true;
            btnUzytkownicy.Click += btnUzytkownicy_Click;
            // 
            // btnUrzadzenia
            // 
            btnUrzadzenia.Location = new Point(10, 212);
            btnUrzadzenia.Name = "btnUrzadzenia";
            btnUrzadzenia.Size = new Size(246, 93);
            btnUrzadzenia.TabIndex = 2;
            btnUrzadzenia.Text = "Urządzenia";
            btnUrzadzenia.UseVisualStyleBackColor = true;
            btnUrzadzenia.Click += btnUrzadzenia_Click;
            // 
            // btnFaktury
            // 
            btnFaktury.Location = new Point(10, 311);
            btnFaktury.Name = "btnFaktury";
            btnFaktury.Size = new Size(246, 93);
            btnFaktury.TabIndex = 3;
            btnFaktury.Text = "Faktury";
            btnFaktury.UseVisualStyleBackColor = true;
            btnFaktury.Click += btnFaktury_Click;
            // 
            // btnZamknij
            // 
            btnZamknij.Location = new Point(10, 576);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Size = new Size(246, 93);
            btnZamknij.TabIndex = 5;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // dgvLogi
            // 
            dgvLogi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogi.Dock = DockStyle.Fill;
            dgvLogi.Location = new Point(280, 3);
            dgvLogi.Name = "dgvLogi";
            dgvLogi.RowHeadersWidth = 102;
            dgvLogi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogi.Size = new Size(1540, 688);
            dgvLogi.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 277F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvLogi, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1823, 714);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLokalizacje);
            panel1.Controls.Add(btnZamknij);
            panel1.Controls.Add(btnUzytkownicy);
            panel1.Controls.Add(btnFaktury);
            panel1.Controls.Add(btnUrzadzenia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 688);
            panel1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { piToolStripMenuItem, pomocToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1823, 49);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // piToolStripMenuItem
            // 
            piToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zamkniToolStripMenuItem, zamknijToolStripMenuItem });
            piToolStripMenuItem.Name = "piToolStripMenuItem";
            piToolStripMenuItem.Size = new Size(156, 45);
            piToolStripMenuItem.Text = "Program";
            // 
            // zamkniToolStripMenuItem
            // 
            zamkniToolStripMenuItem.Name = "zamkniToolStripMenuItem";
            zamkniToolStripMenuItem.Size = new Size(297, 54);
            zamkniToolStripMenuItem.Text = "Odśwież";
            zamkniToolStripMenuItem.Click += btnOdswiez_Click;
            // 
            // zamknijToolStripMenuItem
            // 
            zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            zamknijToolStripMenuItem.Size = new Size(297, 54);
            zamknijToolStripMenuItem.Text = "Zamknij";
            zamknijToolStripMenuItem.Click += btnZamknij_Click;
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oProgramieToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(134, 45);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(353, 54);
            oProgramieToolStripMenuItem.Text = "O programie";
            oProgramieToolStripMenuItem.Click += oProgramieToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(40, 40);
            statusStrip1.Location = new Point(0, 741);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1823, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1823, 763);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dgvLogi).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLokalizacje;
        private Button btnUzytkownicy;
        private Button btnUrzadzenia;
        private Button btnFaktury;
        private Button btnZamknij;
        private DataGridView dgvLogi;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem piToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private ToolStripMenuItem zamkniToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
    }
}