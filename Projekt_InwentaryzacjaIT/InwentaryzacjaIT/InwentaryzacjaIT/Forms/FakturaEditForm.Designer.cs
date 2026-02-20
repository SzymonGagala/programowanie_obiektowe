namespace InwentaryzacjaIT.Forms
{
    partial class FakturaEditForm
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
            txtNumer = new TextBox();
            txtSprzedawca = new TextBox();
            txtKwota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpData = new DateTimePicker();
            label4 = new Label();
            txtSciezka = new TextBox();
            button1 = new Button();
            label5 = new Label();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // txtNumer
            // 
            txtNumer.Location = new Point(304, 55);
            txtNumer.Name = "txtNumer";
            txtNumer.Size = new Size(605, 47);
            txtNumer.TabIndex = 0;
            // 
            // txtSprzedawca
            // 
            txtSprzedawca.Location = new Point(304, 129);
            txtSprzedawca.Name = "txtSprzedawca";
            txtSprzedawca.Size = new Size(605, 47);
            txtSprzedawca.TabIndex = 1;
            // 
            // txtKwota
            // 
            txtKwota.Location = new Point(304, 201);
            txtKwota.Name = "txtKwota";
            txtKwota.Size = new Size(605, 47);
            txtKwota.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 61);
            label1.Name = "label1";
            label1.Size = new Size(213, 41);
            label1.TabIndex = 3;
            label1.Text = "Numer Faktury";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 135);
            label2.Name = "label2";
            label2.Size = new Size(176, 41);
            label2.TabIndex = 4;
            label2.Text = "Sprzedawca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 207);
            label3.Name = "label3";
            label3.Size = new Size(99, 41);
            label3.TabIndex = 5;
            label3.Text = "Kwota";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(304, 291);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(605, 47);
            dtpData.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 297);
            label4.Name = "label4";
            label4.Size = new Size(79, 41);
            label4.TabIndex = 7;
            label4.Text = "Data";
            // 
            // txtSciezka
            // 
            txtSciezka.Location = new Point(304, 376);
            txtSciezka.Name = "txtSciezka";
            txtSciezka.ReadOnly = true;
            txtSciezka.Size = new Size(290, 47);
            txtSciezka.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(621, 376);
            button1.Name = "button1";
            button1.Size = new Size(288, 47);
            button1.TabIndex = 9;
            button1.Text = "Wybierz plik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnWybierzPlik_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 382);
            label5.Name = "label5";
            label5.Size = new Size(163, 41);
            label5.TabIndex = 10;
            label5.Text = "Plik faktury";
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(304, 483);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(290, 107);
            btnZapisz.TabIndex = 11;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(621, 483);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(288, 107);
            btnAnuluj.TabIndex = 12;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // FakturaEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 668);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtSciezka);
            Controls.Add(label4);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKwota);
            Controls.Add(txtSprzedawca);
            Controls.Add(txtNumer);
            Name = "FakturaEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj/Edytuj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumer;
        private TextBox txtSprzedawca;
        private TextBox txtKwota;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpData;
        private Label label4;
        private TextBox txtSciezka;
        private Button button1;
        private Label label5;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}