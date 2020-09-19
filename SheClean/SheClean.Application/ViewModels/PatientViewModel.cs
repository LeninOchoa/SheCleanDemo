using System.Collections;
using System.Collections.Generic;
using SheClean.Domain.Models;

namespace SheClean.Application.ViewModels
{
    public class PatientViewModel
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
    }
}