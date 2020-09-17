using System.Collections;
using System.Collections.Generic;
using SheClean.Domain.Models;

namespace SheClean.Application.ViewModels
{
    public class PatientViewModel
    {
        public IEnumerable<Patient> Patients { get; set; }
    }
}