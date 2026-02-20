using System;
using System.Diagnostics;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;

namespace InwentaryzacjaIT.Forms
{
    public partial class FakturyListForm : Form
    {
        private readonly FakturyRepository _repository;

        public FakturyListForm()
        {
            InitializeComponent();
            _repository = new FakturyRepository();
            OdswiezListe();
        }

        private void OdswiezListe()
        {
            dgvFaktury.DataSource = null;
            dgvFaktury.DataSource = _repository.GetAll();
            if (dgvFaktury.Columns["Id"] != null) dgvFaktury.Columns["Id"].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new FakturaEditForm().ShowDialog();
            OdswiezListe();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dgvFaktury.SelectedRows.Count > 0)
            {
                int id = (int)dgvFaktury.SelectedRows[0].Cells["Id"].Value;
                new FakturaEditForm(id).ShowDialog();
                OdswiezListe();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dgvFaktury.SelectedRows.Count > 0)
            {
                int id = (int)dgvFaktury.SelectedRows[0].Cells["Id"].Value;
                if (MessageBox.Show("Usunąć fakturę?", "Pytanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _repository.Delete(id);
                    OdswiezListe();
                }
            }
        }

        private void btnOtworzPlik_Click(object sender, EventArgs e)
        {
            if (dgvFaktury.SelectedRows.Count > 0)
            {
                string sciezka = dgvFaktury.SelectedRows[0].Cells["SciezkaDoPliku"].Value.ToString();
                if (!string.IsNullOrEmpty(sciezka))
                {
                    try
                    {
                        // otwieranie pliku PDF
                        Process.Start(new ProcessStartInfo(sciezka) { UseShellExecute = true });
                    }
                    catch { MessageBox.Show("Nie można otworzyć pliku. Sprawdź czy ścieżka jest poprawna."); }
                }
                else
                {
                    MessageBox.Show("Ta faktura nie ma załączonego pliku.");
                }
            }
        }
    }
}