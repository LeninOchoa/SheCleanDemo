using SheClean.Domain.Core.Commands;

namespace SheClean.Domain.Commands
{
    public abstract class PatientCommand : Command
    {
        public string Nachname { get; protected set; }
        public string Vorname { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}