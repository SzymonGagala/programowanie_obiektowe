namespace InwentaryzacjaIT.Forms
{
    partial class LokalizacjaEditForm
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
            txtBudynek = new TextBox();
            txtOpis = new TextBox();
            txtPokoj = new TextBox();
            btnZapisz = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 56);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Nazwa Budynku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 141);
            label2.Name = "label2";
            label2.Size = new Size(208, 41);
            label2.TabIndex = 1;
            label2.Text = "Numer Pokoju";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 223);
            label3.Name = "label3";
            label3.Size = new Size(79, 41);
            label3.TabIndex = 2;
            label3.Text = "Opis";
            // 
            // txtBudynek
            // 
            txtBudynek.Location = new Point(280, 50);
            txtBudynek.Name = "txtBudynek";
            txtBudynek.Size = new Size(380, 47);
            txtBudynek.TabIndex = 3;
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(280, 223);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(380, 174);
            txtOpis.TabIndex = 4;
            // 
            // txtPokoj
            // 
            txtPokoj.Location = new Point(280, 135);
            txtPokoj.Name = "txtPokoj";
            txtPokoj.Size = new Size(380, 47);
            txtPokoj.TabIndex = 5;
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(280, 426);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(188, 58);
            btnZapisz.TabIndex = 6;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(472, 426);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(188, 58);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // LokalizacjaEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 537);
            Controls.Add(btnAnuluj);
            Controls.Add(btnZapisz);
            Controls.Add(txtPokoj);
            Controls.Add(txtOpis);
            Controls.Add(txtBudynek);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LokalizacjaEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj/Edytuj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBudynek;
        private TextBox txtOpis;
        private TextBox txtPokoj;
        private Button btnZapisz;
        private Button btnAnuluj;
    }
}