using System;

namespace InwentaryzacjaIT.Models
{
    public class Urzadzenie : BaseEntity
    {
        public string NumerSeryjny { get; set; }
        public string NumerInwentarzowy { get; set; }
        public string Model { get; set; }
        public string Producent { get; set; }
        public DateTime DataZakupu { get; set; }
        public DateTime? DataGwarancji { get; set; }
        public int IdStatusu { get; set; }
        public int IdLokalizacji { get; set; }
        public int? IdUzytkownika { get; set; }
        public int? IdFaktury { get; set; }
        public int? IdRodzaju { get; set; }
    }
}