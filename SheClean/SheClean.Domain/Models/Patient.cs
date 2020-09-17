namespace SheClean.Domain.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string PatientNr { get; set; }
        public string ImageUrl { get; set; }
    }
}