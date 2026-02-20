using System;

namespace InwentaryzacjaIT.Models
{
    public class Log : BaseEntity
    {
        public int? IdUrzadzenia { get; set; }
        public DateTime DataZdarzenia { get; set; }
        public string TypZdarzenia { get; set; }
        public string StaraWartosc { get; set; }
        public string NowaWartosc { get; set; }
    }
}