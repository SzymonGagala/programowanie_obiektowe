using System;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Forms
{
    public partial class UzytkownikEditForm : Form
    {
        private readonly UzytkownicyRepository _repository;
        private int? _id;

        public UzytkownikEditForm(int? id = null)
        {
            InitializeComponent();
            _repository = new UzytkownicyRepository();
            _id = id;
            WczytajDane();
        }

        private void WczytajDane()
        {
            if (_id.HasValue)
            {
                Text = "Edycja Użytkownika";
                var user = _repository.GetById(_id.Value);
                if (user != null)
                {
                    txtImie.Text = user.Imie;
                    txtNazwisko.Text = user.Nazwisko;
                    txtLogin.Text = user.NazwaUzytkownika;
                }
            }
            else
            {
                Text = "Nowy Użytkownik";
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazwisko.Text) || string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Nazwisko i Login są wymagane!");
                return;
            }

            var user = new Uzytkownik
            {
                Imie = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                NazwaUzytkownika = txtLogin.Text
            };

            try
            {
                if (_id.HasValue)
                {
                    user.Id = _id.Value;
                    _repository.Update(user);
                }
                else
                {
                    _repository.Add(user);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu (sprawdz czy login już istnieje): " + ex.Message);
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}