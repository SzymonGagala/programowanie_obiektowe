using System;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Forms
{
    public partial class UzytkownicyListForm : Form
    {
        private readonly UzytkownicyRepository _repository;

        public UzytkownicyListForm()
        {
            InitializeComponent();
            _repository = new UzytkownicyRepository();
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            try
            {
                dgvUzytkownicy.DataSource = null;
                dgvUzytkownicy.DataSource = _repository.GetAll();

                // Ukrywa id, jeśli kolumna istnieje
                if (dgvUzytkownicy.Columns["Id"] != null) dgvUzytkownicy.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new UzytkownikEditForm();
            form.ShowDialog();
            OdswiezListe();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dgvUzytkownicy.SelectedRows.Count > 0)
            {
                int id = (int)dgvUzytkownicy.SelectedRows[0].Cells["Id"].Value;
                var form = new UzytkownikEditForm(id);
                form.ShowDialog();
                OdswiezListe();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dgvUzytkownicy.SelectedRows.Count > 0)
            {
                var row = dgvUzytkownicy.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;
                string nazwisko = row.Cells["Nazwisko"].Value.ToString();

                if (MessageBox.Show($"Usunąć użytkownika {nazwisko}?", "Pytanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _repository.Delete(id);
                        OdswiezListe();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie można usunąć użytkownika (sprawdź czy ma przypisany sprzęt).\nBłąd: " + ex.Message);
                    }
                }
            }
        }
    }
}