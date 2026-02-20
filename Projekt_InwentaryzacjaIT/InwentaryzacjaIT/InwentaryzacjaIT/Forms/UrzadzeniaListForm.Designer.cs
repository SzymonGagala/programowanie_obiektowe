namespace InwentaryzacjaIT.Forms
{
    partial class UrzadzeniaListForm
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
            dgvUrzadzenia = new DataGridView();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvUrzadzenia).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUrzadzenia
            // 
            dgvUrzadzenia.AllowUserToAddRows = false;
            dgvUrzadzenia.AllowUserToDeleteRows = false;
            dgvUrzadzenia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrzadzenia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrzadzenia.Dock = DockStyle.Fill;
            dgvUrzadzenia.Location = new Point(253, 3);
            dgvUrzadzenia.Name = "dgvUrzadzenia";
            dgvUrzadzenia.ReadOnly = true;
            dgvUrzadzenia.RowHeadersWidth = 102;
            dgvUrzadzenia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrzadzenia.Size = new Size(2437, 779);
            dgvUrzadzenia.TabIndex = 0;
            dgvUrzadzenia.CellMouseDoubleClick += dgvUrzadzenia_CellMouseDoubleClick;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(13, 43);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(241, 58);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Location = new Point(13, 132);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(241, 58);
            btnEdytuj.TabIndex = 2;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(13, 224);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(241, 58);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usun";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnUsun);
            panel1.Controls.Add(btnEdytuj);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 779);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvUrzadzenia, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2693, 785);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // UrzadzeniaListForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2693, 785);
            Controls.Add(tableLayoutPanel1);
            Name = "UrzadzeniaListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urzadzenia";
            ((System.ComponentModel.ISupportInitialize)dgvUrzadzenia).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUrzadzenia;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}