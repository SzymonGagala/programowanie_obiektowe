using System;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Forms
{
    public partial class LokalizacjaEditForm : Form
    {
        private readonly LokalizacjeRepository _repository;
        private int? _idEdytowane; // null = Dodawanie, liczba = Edycja
        // Parametr "id" jest opcjonalny, jeśli uzytkownik go nie doda czyli wartość null, formularz wie, że dodaje
        // jeśli poda formularz wie, że edytuje.

        public LokalizacjaEditForm(int? id = null)
        {
            InitializeComponent();
            _repository = new LokalizacjeRepository();
            _idEdytowane = id;

            PrzygotujFormularz();
        }

        private void PrzygotujFormularz()
        {
            if (_idEdytowane.HasValue)
            {
                // edycja - Pobiera dane z bazy i wpisuje w pola
                this.Text = "Edycja Lokalizacji";
                var lok = _repository.GetById(_idEdytowane.Value);

                if (lok != null)
                {
                    txtBudynek.Text = lok.NazwaBudynku;
                    txtPokoj.Text = lok.NumerPokoju;
                    txtOpis.Text = lok.Opis;
                }
            }
            else
            {
                // dodawanie
                this.Text = "Nowa Lokalizacja";
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            // Walidacja
            if (string.IsNullOrWhiteSpace(txtBudynek.Text) || string.IsNullOrWhiteSpace(txtPokoj.Text))
            {
                MessageBox.Show("Musisz podać nazwę budynku i numer pokoju!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tworzy obiekt z danych pól
            var lok = new Lokalizacja
            {
                NazwaBudynku = txtBudynek.Text,
                NumerPokoju = txtPokoj.Text,
                Opis = txtOpis.Text
            };

            try
            {
                if (_idEdytowane.HasValue)
                {
                    // aktualizacja
                    lok.Id = _idEdytowane.Value;
                    _repository.Update(lok);
                }
                else
                {
                    // dodawanie
                    _repository.Add(lok);
                }

                MessageBox.Show("Zapisano pomyślnie!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu: " + ex.Message);
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}