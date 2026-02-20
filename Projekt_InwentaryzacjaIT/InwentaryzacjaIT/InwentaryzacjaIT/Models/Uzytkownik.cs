namespace InwentaryzacjaIT.Models
{
    public class Uzytkownik : BaseEntity
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NazwaUzytkownika { get; set; }
        public string ImieNazwisko => $"{Imie} {Nazwisko}";
    }
}