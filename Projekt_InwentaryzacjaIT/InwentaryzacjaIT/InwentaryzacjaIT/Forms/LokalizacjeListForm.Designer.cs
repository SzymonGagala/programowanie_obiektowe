namespace InwentaryzacjaIT.Forms
{
    partial class LokalizacjeListForm
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
            dgvLokalizacje = new DataGridView();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvLokalizacje).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLokalizacje
            // 
            dgvLokalizacje.AccessibleRole = AccessibleRole.TitleBar;
            dgvLokalizacje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLokalizacje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLokalizacje.Dock = DockStyle.Fill;
            dgvLokalizacje.Location = new Point(265, 3);
            dgvLokalizacje.Name = "dgvLokalizacje";
            dgvLokalizacje.RowHeadersWidth = 102;
            dgvLokalizacje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLokalizacje.Size = new Size(1410, 814);
            dgvLokalizacje.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(9, 73);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(230, 58);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Location = new Point(9, 158);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(230, 58);
            btnEdytuj.TabIndex = 2;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(9, 238);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(230, 58);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usun";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvLokalizacje, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1678, 820);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnEdytuj);
            panel1.Controls.Add(btnUsun);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 814);
            panel1.TabIndex = 5;
            // 
            // LokalizacjeListForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 820);
            Controls.Add(tableLayoutPanel1);
            Name = "LokalizacjeListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lokalizacje";
            ((System.ComponentModel.ISupportInitialize)dgvLokalizacje).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLokalizacje;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}