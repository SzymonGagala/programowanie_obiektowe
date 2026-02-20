using System;

namespace InwentaryzacjaIT.Models
{
    public class Faktura : BaseEntity
    {
        public string NumerFaktury { get; set; }
        public DateTime DataWystawienia { get; set; }
        public string Sprzedawca { get; set; }
        public decimal Kwota { get; set; }
        public string SciezkaDoPliku { get; set; }

        public override string ToString()
        {
            return NumerFaktury;
        }
    }
}