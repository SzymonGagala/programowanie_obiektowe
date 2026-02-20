using System;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Forms
{
    public partial class LokalizacjeListForm : Form
    {
        private readonly LokalizacjeRepository _repository;

        public LokalizacjeListForm()
        {
            InitializeComponent();
            _repository = new LokalizacjeRepository();

            OdswiezListe();
        }

        private void OdswiezListe()
        {
            try
            {
                var lista = _repository.GetAll();
                
                dgvLokalizacje.DataSource = null;
                dgvLokalizacje.DataSource = lista;

                if (dgvLokalizacje.Columns["Id"] != null)
                {
                    dgvLokalizacje.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new LokalizacjaEditForm();

            form.ShowDialog();
            OdswiezListe();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            // sprawdza, czy użytkownik zaznaczył jakiś wiersz
            if (dgvLokalizacje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć wiersz do edycji.");
                return;
            }

            int id = (int)dgvLokalizacje.SelectedRows[0].Cells["Id"].Value;

            // otwiera forumlarz edycji z przekazanym id
            var form = new LokalizacjaEditForm(id);
            form.ShowDialog();
            OdswiezListe();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            // sprawdza czy jest cos zaznaczone
            if (dgvLokalizacje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć wiersz do usunięcia.");
                return;
            }

            // pobiera id i nazwe
            var row = dgvLokalizacje.SelectedRows[0];
            int id = (int)row.Cells["Id"].Value;
            string nazwa = row.Cells["NazwaBudynku"].Value.ToString();

            // decyzja na zatwierdzenie usuniecia lokalizacji
            var decyzja = MessageBox.Show($"Czy na pewno chcesz usunąć lokalizację: {nazwa}?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (decyzja == DialogResult.Yes)
            {
                try
                {
                    // usuwa z bazy
                    _repository.Delete(id);

                    OdswiezListe();
                    MessageBox.Show("Usunięto pomyślnie.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można usunąć tej lokalizacji. Prawdopodobnie są do niej przypisane urządzenia!\n\nSzczegóły błędu: " + ex.Message);
                }
            }
        }
    }
}