using System;
using System.Data;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;

namespace InwentaryzacjaIT.Forms
{
    public partial class Form1 : Form
    {
        private readonly LogiRepository _repoLogi;
        private UrzadzeniaListForm formUrzadzenia;

        public Form1()
        {
            InitializeComponent();

            // Inicjalizacja repozytorium Logów
            _repoLogi = new LogiRepository();

            dgvLogi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogi.ReadOnly = true;
            dgvLogi.AllowUserToAddRows = false;

            OdswiezLogi(null);
        }

        public Form1(string id)
        {
            InitializeComponent();

            _repoLogi = new LogiRepository();

            dgvLogi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogi.ReadOnly = true;
            dgvLogi.AllowUserToAddRows = false;

            OdswiezLogi(id);

            // Dostosowanie interfejsu dla okna szczegółów
            tableLayoutPanel1.ColumnStyles[0].Width = 0;
            this.Text = "Szczegóły histori urządzenia";
            panel1.Visible = false;
        }

        public void OdswiezLogi(string id = null)
        {
            try
            {
                dgvLogi.DataSource = _repoLogi.PobierzWszystkieLogi(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania historii: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLokalizacje_Click(object sender, EventArgs e)
        {  
            new LokalizacjeListForm().ShowDialog(); // Wywołanie ShowDialog wstrzymuje wykonanie kodu w oknie głównym.
            OdswiezLogi(null); // Odświeżenie po zamknięciu
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            new UzytkownicyListForm().ShowDialog();
            OdswiezLogi(null);
        }

        private void btnUrzadzenia_Click(object sender, EventArgs e)
        {
                // Przekazanie referencji do okna głównego pozwala oknu odświeżyć logi
                formUrzadzenia = new UrzadzeniaListForm(this);
                formUrzadzenia.Show(); // Otwieranie formularza w trybie Show
        }

        private void btnFaktury_Click(object sender, EventArgs e)
        {
            new FakturyListForm().ShowDialog();
            OdswiezLogi(null);
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            OdswiezLogi(null);
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 forma = new AboutBox1();
            forma.ShowDialog();
        }
    }
}