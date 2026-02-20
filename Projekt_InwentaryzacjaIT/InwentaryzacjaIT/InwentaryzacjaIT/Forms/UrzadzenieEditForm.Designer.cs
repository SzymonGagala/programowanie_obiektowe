namespace InwentaryzacjaIT.Forms
{
    partial class UrzadzenieEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSN = new TextBox();
            txtModel = new TextBox();
            txtProducent = new TextBox();
            dtpZakup = new DateTimePicker();
            dtpGwarancja = new DateTimePicker();
            cmbStatus = new ComboBox();
            cmbLokalizacja = new ComboBox();
            cmbUzytkownik = new ComboBox();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            txtNrInw = new TextBox();
            label9 = new Label();
            cmbFaktura = new ComboBox();
            label10 = new Label();
            cmbRodzaj = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 371);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 0;
            label1.Text = "Numer seryjny";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 310);
            label2.Name = "label2";
            label2.Size = new Size(104, 41);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 243);
            label3.Name = "label3";
            label3.Size = new Size(155, 41);
            label3.TabIndex = 3;
            label3.Text = "Producent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 576);
            label4.Name = "label4";
            label4.Size = new Size(186, 41);
            label4.TabIndex = 2;
            label4.Text = "Data Zakupu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 647);
            label5.Name = "label5";
            label5.Size = new Size(201, 41);
            label5.TabIndex = 5;
            label5.Text = "Gwarancja Do";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 763);
            label6.Name = "label6";
            label6.Size = new Size(98, 41);
            label6.TabIndex = 4;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 831);
            label7.Name = "label7";
            label7.Size = new Size(159, 41);
            label7.TabIndex = 6;
            label7.Text = "Lokalizacja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 904);
            label8.Name = "label8";
            label8.Size = new Size(172, 41);
            label8.TabIndex = 7;
            label8.Text = "Użytkownik";
            // 
            // txtSN
            // 
            txtSN.Location = new Point(297, 371);
            txtSN.Name = "txtSN";
            txtSN.Size = new Size(530, 47);
            txtSN.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(297, 304);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(530, 47);
            txtModel.TabIndex = 9;
            // 
            // txtProducent
            // 
            txtProducent.Location = new Point(297, 237);
            txtProducent.Name = "txtProducent";
            txtProducent.Size = new Size(530, 47);
            txtProducent.TabIndex = 10;
            // 
            // dtpZakup
            // 
            dtpZakup.Location = new Point(297, 570);
            dtpZakup.Name = "dtpZakup";
            dtpZakup.Size = new Size(530, 47);
            dtpZakup.TabIndex = 11;
            // 
            // dtpGwarancja
            // 
            dtpGwarancja.Location = new Point(297, 641);
            dtpGwarancja.Name = "dtpGwarancja";
            dtpGwarancja.Size = new Size(530, 47);
            dtpGwarancja.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(297, 755);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(530, 49);
            cmbStatus.TabIndex = 13;
            // 
            // cmbLokalizacja
            // 
            cmbLokalizacja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLokalizacja.FormattingEnabled = true;
            cmbLokalizacja.Location = new Point(297, 823);
            cmbLokalizacja.Name = "cmbLokalizacja";
            cmbLokalizacja.Size = new Size(530, 49);
            cmbLokalizacja.TabIndex = 14;
            // 
            // cmbUzytkownik
            // 
            cmbUzytkownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUzytkownik.FormattingEnabled = true;
            cmbUzytkownik.Location = new Point(297, 896);
            cmbUzytkownik.Name = "cmbUzytkownik";
            cmbUzytkownik.Size = new Size(530, 49);
            cmbUzytkownik.TabIndex = 15;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(297, 987);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(252, 86);
            btnZapisz.TabIndex = 16;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(575, 987);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(252, 86);
            btnAnuluj.TabIndex = 17;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // txtNrInw
            // 
            txtNrInw.Location = new Point(297, 46);
            txtNrInw.Name = "txtNrInw";
            txtNrInw.Size = new Size(530, 47);
            txtNrInw.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 46);
            label9.Name = "label9";
            label9.Size = new Size(256, 41);
            label9.TabIndex = 18;
            label9.Text = "Nr Identyfikacyjny";
            // 
            // cmbFaktura
            // 
            cmbFaktura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaktura.FormattingEnabled = true;
            cmbFaktura.Location = new Point(297, 499);
            cmbFaktura.Name = "cmbFaktura";
            cmbFaktura.Size = new Size(530, 49);
            cmbFaktura.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(136, 507);
            label10.Name = "label10";
            label10.Size = new Size(154, 41);
            label10.TabIndex = 20;
            label10.Text = "Nr Faktury";
            // 
            // cmbRodzaj
            // 
            cmbRodzaj.FormattingEnabled = true;
            cmbRodzaj.Location = new Point(297, 164);
            cmbRodzaj.Name = "cmbRodzaj";
            cmbRodzaj.Size = new Size(530, 49);
            cmbRodzaj.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(75, 172);
            label11.Name = "label11";
            label11.Size = new Size(216, 41);
            label11.TabIndex = 22;
            label11.Text = "Typ urządzenia";
            // 
            // UrzadzenieEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 1166);
            Controls.Add(cmbRodzaj);
            Controls.Add(label11);
            Controls.Add(cmbFaktura);
            Controls.Add(label10);
            Controls.Add(txtNrInw);
            Controls.Add(label9);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(cmbUzytkownik);
            Controls.Add(cmbLokalizacja);
            Controls.Add(cmbStatus);
            Controls.Add(dtpGwarancja);
            Controls.Add(dtpZakup);
            Controls.Add(txtProducent);
            Controls.Add(txtModel);
            Controls.Add(txtSN);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrzadzenieEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj/Edytuj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSN;
        private TextBox txtModel;
        private TextBox txtProducent;
        private DateTimePicker dtpZakup;
        private DateTimePicker dtpGwarancja;
        private ComboBox cmbStatus;
        private ComboBox cmbLokalizacja;
        private ComboBox cmbUzytkownik;
        private Button btnZapisz;
        private Button btnAnuluj;
        private TextBox txtNrInw;
        private Label label9;
        private ComboBox cmbFaktura;
        private Label label10;
        private ComboBox cmbRodzaj;
        private Label label11;
    }
}