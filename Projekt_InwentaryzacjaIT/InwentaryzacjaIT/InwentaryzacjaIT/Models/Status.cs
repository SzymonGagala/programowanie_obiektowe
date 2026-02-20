namespace InwentaryzacjaIT.Models
{
    public class Status : BaseEntity
    {
        public string Nazwa { get; set; }
        public override string ToString()
        {
            return Nazwa;
        }
    }
}