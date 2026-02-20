using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InwentaryzacjaIT.Repositories;
using InwentaryzacjaIT.Models;

namespace InwentaryzacjaIT.Forms
{
    public partial class UrzadzenieEditForm : Form
    {
        // połączenie z bazą danych
        private readonly UrzadzeniaRepository _repoUrzadzenia;
        private readonly StatusyRepository _repoStatusy;
        private readonly LokalizacjeRepository _repoLokalizacje;
        private readonly UzytkownicyRepository _repoUzytkownicy;
        private readonly LogiRepository _repoLogi;
        private readonly RodzajeRepository _repoRodzaje;
        private readonly FakturyRepository _repoFaktury;

        // Jeśil pole ma wartosc - edycja, jeśli null - nowe urzadzenie
        private int? _idEdytowane;

        // zmienne do logowania starych wartosci dla logów historycznych
        private string _staryStatus;
        private string _staraLokalizacja;
        private string _staryUzytkownik;
        private string _starySN;
        private string _staryModel;
        private string _staryNrInw;
        private string _staryRodzaj;
        private string _staraFaktura;

        public UrzadzenieEditForm(int? id = null)
        {
            InitializeComponent();

            // Inicjalizacja wszystkich repozytoriów
            _repoUrzadzenia = new UrzadzeniaRepository();
            _repoStatusy = new StatusyRepository();
            _repoLokalizacje = new LokalizacjeRepository();
            _repoUzytkownicy = new UzytkownicyRepository();
            _repoLogi = new LogiRepository();
            _repoRodzaje = new RodzajeRepository();
            _repoFaktury = new FakturyRepository();

            _idEdytowane = id; // Przypisanie id lub null

            ZaladujListyRozwijane();
            WczytajDane();
        }

        // metoda pobiera dane z bazy do list rozwijalnych
        private void ZaladujListyRozwijane()
        {
            cmbStatus.DataSource = _repoStatusy.GetAll();
            cmbStatus.DisplayMember = "Nazwa";
            cmbStatus.ValueMember = "Id";

            cmbLokalizacja.DataSource = _repoLokalizacje.GetAll();
            cmbLokalizacja.DisplayMember = "PelnaNazwa";
            cmbLokalizacja.ValueMember = "Id";

            var uzytkownicy = _repoUzytkownicy.GetAll();
            // Insert(0) dodaje sztuczny element na początku listy by wyswietlac "brak"
            uzytkownicy.Insert(0, new Uzytkownik { Id = -1, Imie = "----- BRAK -----", Nazwisko = "", NazwaUzytkownika = "" });
            cmbUzytkownik.DataSource = uzytkownicy;
            cmbUzytkownik.DisplayMember = "ImieNazwisko";
            cmbUzytkownik.ValueMember = "Id";

            cmbRodzaj.DataSource = _repoRodzaje.GetAll();
            cmbRodzaj.DisplayMember = "Nazwa";
            cmbRodzaj.ValueMember = "Id";

            var faktury = _repoFaktury.GetAll();
            faktury.Insert(0, new Faktura { Id = -1, NumerFaktury = "----- BRAK -----" });
            cmbFaktura.DataSource = faktury;
            cmbFaktura.DisplayMember = "NumerFaktury";
            cmbFaktura.ValueMember = "Id";
        }

        // wczytywanie formularza
        private void WczytajDane()
        {
            if (_idEdytowane.HasValue)
            {
                Text = "Edycja Urządzenia";
                var urz = _repoUrzadzenia.GetById(_idEdytowane.Value);

                if (urz != null)
                {
                    // Wypełniamy pola tekstowe
                    txtNrInw.Text = urz.NumerInwentarzowy;
                    txtSN.Text = urz.NumerSeryjny;
                    txtModel.Text = urz.Model;
                    txtProducent.Text = urz.Producent;

                    dtpZakup.Value = urz.DataZakupu;
                    if (urz.DataGwarancji.HasValue) dtpGwarancja.Value = urz.DataGwarancji.Value;

                    // ustawia listy rozwijalne na odpowiednie pozycje id
                    cmbStatus.SelectedValue = urz.IdStatusu;
                    cmbLokalizacja.SelectedValue = urz.IdLokalizacji;

                    // Dla pól opcjonalnych gdzie w bazie jest null, ustawiamy -1 ("BRAK") lub domyślny 1
                    cmbUzytkownik.SelectedValue = urz.IdUzytkownika ?? -1;
                    cmbRodzaj.SelectedValue = urz.IdRodzaju ?? 1;
                    cmbFaktura.SelectedValue = urz.IdFaktury ?? -1;

                    // zapamietywanie stanu starych zmiennych
                    _staryStatus = cmbStatus.Text;
                    _staraLokalizacja = cmbLokalizacja.Text;
                    _staryUzytkownik = cmbUzytkownik.Text;
                    _starySN = txtSN.Text;
                    _staryModel = txtModel.Text;
                    _staryNrInw = txtNrInw.Text;
                    _staryRodzaj = cmbRodzaj.Text;
                    _staraFaktura = cmbFaktura.Text;
                }
            }
            else
            {
                Text = "Nowe Urządzenie";
                dtpZakup.Value = DateTime.Now;
                dtpGwarancja.Value = DateTime.Now.AddYears(2); // gwarancja domyslnie ustawiona na 2 lata

                // generowanie numeru identyfiakcyjnego 
                try
                {
                    // sprawdza najnizszy dostepny numer
                    txtNrInw.Text = GenerujWolnyNumer();
                }
                catch (Exception ex)
                {
                    // jeśłi nastapi awaria zostanie przypisany kod "000000"
                    MessageBox.Show("Nie udało się wygenerować numeru automatycznie: " + ex.Message);
                    txtNrInw.Text = "000000";
                }
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            // walidacja
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model jest wymagany!");
                return;
            }

            // pobieranie danych z formularza
            int idStatus = (int)cmbStatus.SelectedValue;
            int idLokalizacja = (int)cmbLokalizacja.SelectedValue;

            // obsługa wartości opcjonalnych
            int idUser = (int)cmbUzytkownik.SelectedValue;
            int? idUserDatabase = idUser == -1 ? (int?)null : idUser;

            int idFaktura = (int)cmbFaktura.SelectedValue;
            int? idFakturaDatabase = idFaktura == -1 ? (int?)null : idFaktura;

            string nazwaRodzaju = cmbRodzaj.Text;

            // Jesli rodzaj jest pusty nadawana jest nazwa "Inne"
            if (string.IsNullOrWhiteSpace(nazwaRodzaju)) nazwaRodzaju = "Inne";

            // metoda sprawdza czy taki rodzaj istenie, jesli nie tworzy nowy, jesli tak pobiera id
            int idRodzaj = _repoRodzaje.PobierzLubDodaj(nazwaRodzaju);


            var urz = new Urzadzenie
            {
                NumerInwentarzowy = txtNrInw.Text,
                NumerSeryjny = txtSN.Text,
                Model = txtModel.Text,
                Producent = txtProducent.Text,
                DataZakupu = dtpZakup.Value,
                DataGwarancji = dtpGwarancja.Value,
                IdStatusu = idStatus,
                IdLokalizacji = idLokalizacja,
                IdUzytkownika = idUserDatabase,
                IdRodzaju = idRodzaj,
                IdFaktury = idFakturaDatabase
            };

            try
            {
                if (_idEdytowane.HasValue)
                {
                    urz.Id = _idEdytowane.Value;
                    _repoUrzadzenia.Update(urz);

                    // porownywanie starych i nowych wartosci do określenia logów
                    SprawdzZmiane("Zmiana Statusu", _staryStatus, cmbStatus.Text, urz.Id);
                    SprawdzZmiane("Zmiana Lokalizacji", _staraLokalizacja, cmbLokalizacja.Text, urz.Id);
                    SprawdzZmiane("Zmiana Użytkownika", _staryUzytkownik, cmbUzytkownik.Text, urz.Id);
                    SprawdzZmiane("Zmiana SN", _starySN, txtSN.Text, urz.Id);
                    SprawdzZmiane("Zmiana Modelu", _staryModel, txtModel.Text, urz.Id);
                    SprawdzZmiane("Zmiana Nr Inw.", _staryNrInw, txtNrInw.Text, urz.Id);
                    SprawdzZmiane("Zmiana Typu", _staryRodzaj, cmbRodzaj.Text, urz.Id);
                    SprawdzZmiane("Zmiana Faktury", _staraFaktura, cmbFaktura.Text, urz.Id);
                }
                else
                {
                    // Metoda zwraca teraz nowe id kluczowe do logowania
                    int noweId = _repoUrzadzenia.Add(urz);

                    _repoLogi.Add(new Log
                    {
                        IdUrzadzenia = noweId,
                        TypZdarzenia = "Utworzenie",
                        StaraWartosc = "---",
                        NowaWartosc = $"Nr: {urz.NumerInwentarzowy}, Model: {urz.Model}"
                    });
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu: " + ex.Message);
            }
        }

        // loguje zdarzenie tylko wtedy, gdy stara wartość różni się od nowej
        private void SprawdzZmiane(string typ, string stara, string nowa, int id)
        {
            if (stara != nowa)
            {
                _repoLogi.Add(new Log
                {
                    IdUrzadzenia = id,
                    TypZdarzenia = typ,
                    StaraWartosc = stara,
                    NowaWartosc = nowa
                });
            }
        }

        // metoda szuka pierwszego wolnego kodu urzadzenia
        private string GenerujWolnyNumer()
        {
            // pobiera wszystkie zajęte numery z bazy
            var zajeteNumery = _repoUrzadzenia.PobierzZajeteNumery();

            int licznik = 1;
            while (true)
            {
                // Format D6 zamienia liczbę 5 na "000005"
                string kandydat = $"IT{licznik:D6}";

                // jeśli lista nie zawiera tego numeru, to znaczy że jest wolny
                if (!zajeteNumery.Contains(kandydat))
                {
                    return kandydat;
                }

                // jeśli zajęty, sprawdza nastepne
                licznik++;
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}