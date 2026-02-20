namespace InwentaryzacjaIT.Forms
{
    partial class UzytkownikEditForm
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
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // txtImie
            // 
            txtImie.Location = new Point(235, 32);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(320, 47);
            txtImie.TabIndex = 0;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(235, 106);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(320, 47);
            txtNazwisko.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(235, 174);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(320, 47);
            txtLogin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 41);
            label1.TabIndex = 3;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 112);
            label2.Name = "label2";
            label2.Size = new Size(144, 41);
            label2.TabIndex = 4;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 180);
            label3.Name = "label3";
            label3.Size = new Size(204, 41);
            label3.TabIndex = 5;
            label3.Text = "Nazwa własna";
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(25, 253);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(227, 85);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(328, 253);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(227, 85);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // UzytkownikEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 410);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Name = "UzytkownikEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj/Edytuj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}