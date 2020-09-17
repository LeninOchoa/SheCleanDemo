namespace SheClean.Domain.Commands
{
    public class CreatePatientCommand : PatientCommand
    {
        public CreatePatientCommand(string nachname, string vorname, string imageUrl)
        {
            Nachname = nachname;
            Vorname = vorname;
            ImageUrl = imageUrl;
        }
    }
}