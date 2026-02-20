using System;
using System.Drawing;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;
using InwentaryzacjaIT.Interfaces;

namespace InwentaryzacjaIT.Forms
{
    public partial class UrzadzeniaListForm : Form
    {
        // wykorzystuje interfejs
        private readonly IRepository<Urzadzenie> _repository;

        private readonly UrzadzeniaRepository _repoGrid;

        private readonly LogiRepository _repoLogi;

        // referencja do odświeżania logów w tle.
        private readonly Form1 _mainForm;

        public UrzadzeniaListForm()
        {
            InitializeComponent();

            // Inicjalizacja repozytorium w którym zastosowano polimorfizm
            var repo = new UrzadzeniaRepository();
            _repository = repo;
            _repoGrid = repo;

            _repoLogi = new LogiRepository();

            dgvUrzadzenia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            OdswiezListe();
        }

        public UrzadzeniaListForm(Form1 mainForm) : this()
        {
            _mainForm = mainForm;
        }

        // synchronizacja siatki danych z bazą
        private void OdswiezListe()
        {
            try
            {
                // Pobranie z bazy
                dgvUrzadzenia.DataSource = _repoGrid.PobierzWszystkoDoWyswietlenia();

                // formatowanie wiersza na podstawie statusu urządzenia
                foreach (DataGridViewRow dr in dgvUrzadzenia.Rows)
                {
                    if (dr.Cells["Status"].Value != null &&
                        dr.Cells["Status"].Value.ToString().Equals("W użyciu", StringComparison.OrdinalIgnoreCase))
                    {
                        dr.Cells["Status"].Style.ForeColor = Color.LimeGreen;
                    }
                }

                // Ukrycie kolumny z kluczem głównym 
                if (dgvUrzadzenia.Columns["Id"] != null)
                {
                    dgvUrzadzenia.Columns["Id"].Visible = false;
                }


                if (_mainForm != null)
                {
                    _mainForm.OdswiezLogi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas odświeżania listy urządzeń: " + ex.Message, "Błąd odczytu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dgvUrzadzenia.SelectedRows.Count > 0)
            {
                var row = dgvUrzadzenia.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;
                string model = row.Cells["Model"].Value.ToString();

                // sprawdzanie czy kolumna numery seryjnego jest wartoscia null
                string sn = row.Cells["Numer seryjny"].Value != null ? row.Cells["Numer seryjny"].Value.ToString() : "Brak SN";

                if (MessageBox.Show($"Czy na pewno chcesz usunąć urządzenie: {model}?", "Potwierdzenie operacji", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        // Zapisanie zdarzenia usunięcia do tabeli logow przed usunięciem rekordu
                        _repoLogi.Add(new Log
                        {
                            IdUrzadzenia = id,
                            TypZdarzenia = "Usunięcie",
                            StaraWartosc = $"{model} (SN: {sn})",
                            NowaWartosc = "--- USUNIĘTO ---"
                        });

                        _repository.Delete(id);

                        OdswiezListe();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas usuwania rekordu: " + ex.Message, "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć cały wiersz urządzenia, które chcesz usunąć.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new UrzadzenieEditForm();
            form.ShowDialog();
            OdswiezListe();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dgvUrzadzenia.SelectedRows.Count > 0)
            {
                int id = (int)dgvUrzadzenia.SelectedRows[0].Cells["Id"].Value;
                // Przekazanie id edytowanego rekordu
                var form = new UrzadzenieEditForm(id);
                form.ShowDialog();

                OdswiezListe();
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć cały wiersz urządzenia do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUrzadzenia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // weryfikacja czy kliknięto w dane czy nagłówek kolumn
            if (e.RowIndex >= 0)
            {
                string id = dgvUrzadzenia.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                // wyświetlanie historii tylko jednego urządzenia
                Form1 formSzczegoly = new Form1(id);
                formSzczegoly.ShowDialog();
            }
        }
    }
}