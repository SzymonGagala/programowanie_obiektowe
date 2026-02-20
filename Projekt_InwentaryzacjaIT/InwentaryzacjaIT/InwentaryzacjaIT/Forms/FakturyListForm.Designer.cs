namespace InwentaryzacjaIT.Forms
{
    partial class FakturyListForm
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
            dgvFaktury = new DataGridView();
            btnDodaj = new Button();
            btnEdytuj = new Button();
            btnUsun = new Button();
            btnOtworzPlik = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFaktury).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFaktury
            // 
            dgvFaktury.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaktury.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaktury.Dock = DockStyle.Fill;
            dgvFaktury.Location = new Point(244, 3);
            dgvFaktury.Name = "dgvFaktury";
            dgvFaktury.RowHeadersWidth = 102;
            dgvFaktury.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFaktury.Size = new Size(1508, 817);
            dgvFaktury.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(9, 55);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(218, 58);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Location = new Point(9, 154);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(218, 58);
            btnEdytuj.TabIndex = 2;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(9, 252);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(218, 58);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnOtworzPlik
            // 
            btnOtworzPlik.Location = new Point(9, 667);
            btnOtworzPlik.Name = "btnOtworzPlik";
            btnOtworzPlik.Size = new Size(218, 58);
            btnOtworzPlik.TabIndex = 4;
            btnOtworzPlik.Text = "Otworz Plik";
            btnOtworzPlik.UseVisualStyleBackColor = true;
            btnOtworzPlik.Click += btnOtworzPlik_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFaktury, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1755, 823);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDodaj);
            panel1.Controls.Add(btnEdytuj);
            panel1.Controls.Add(btnOtworzPlik);
            panel1.Controls.Add(btnUsun);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 817);
            panel1.TabIndex = 6;
            // 
            // FakturyListForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1755, 823);
            Controls.Add(tableLayoutPanel1);
            Name = "FakturyListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Faktury";
            ((System.ComponentModel.ISupportInitialize)dgvFaktury).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFaktury;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private Button btnOtworzPlik;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}