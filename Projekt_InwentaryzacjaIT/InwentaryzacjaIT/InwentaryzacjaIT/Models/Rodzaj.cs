namespace InwentaryzacjaIT.Models
{
    public class Rodzaj : BaseEntity
    {
        public string Nazwa { get; set; }
        public override string ToString()
        {
            return Nazwa;
        }
    }
}