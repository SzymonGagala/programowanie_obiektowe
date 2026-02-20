namespace InwentaryzacjaIT.Models
{
    public class Lokalizacja : BaseEntity
    {
        public string NazwaBudynku { get; set; }
        public string NumerPokoju { get; set; }
        public string Opis { get; set; }
        public string PelnaNazwa => $"{NazwaBudynku} - Pokój {NumerPokoju}";
        public override string ToString()
        {
            return PelnaNazwa;
        }
    }
}
