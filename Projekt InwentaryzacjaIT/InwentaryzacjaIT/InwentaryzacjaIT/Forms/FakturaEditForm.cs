using System;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Forms
{
    public partial class FakturaEditForm : Form
    {
        private readonly FakturyRepository _repository;
        private int? _id;

        public FakturaEditForm(int? id = null)
        {
            InitializeComponent();
            _repository = new FakturyRepository();
            _id = id;
            WczytajDane();
        }

        private void WczytajDane()
        {
            if (_id.HasValue)
            {
                Text = "Edycja Faktury";
                var f = _repository.GetById(_id.Value);
                if (f != null)
                {
                    txtNumer.Text = f.NumerFaktury;
                    txtSprzedawca.Text = f.Sprzedawca;
                    txtKwota.Text = f.Kwota.ToString();
                    dtpData.Value = f.DataWystawienia;
                    txtSciezka.Text = f.SciezkaDoPliku;
                }
            }
            else
            {
                Text = "Nowa Faktura";
            }
        }

        // obsługa dodawania plikow faktur 
        private void btnWybierzPlik_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki PDF|*.pdf|Wszystkie pliki|*.*";
                openFileDialog.Title = "Wybierz fakturę PDF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSciezka.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumer.Text) || string.IsNullOrWhiteSpace(txtKwota.Text))
            {
                MessageBox.Show("Numer i Kwota są wymagane!");
                return;
            }

            if (!decimal.TryParse(txtKwota.Text, out decimal kwota))
            {
                MessageBox.Show("Podana kwota nie jest liczbą!");
                return;
            }

            var f = new Faktura
            {
                NumerFaktury = txtNumer.Text,
                Sprzedawca = txtSprzedawca.Text,
                Kwota = kwota,
                DataWystawienia = dtpData.Value,
                SciezkaDoPliku = txtSciezka.Text
            };

            try
            {
                if (_id.HasValue)
                {
                    f.Id = _id.Value;
                    _repository.Update(f);
                }
                else
                {
                    _repository.Add(f);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}