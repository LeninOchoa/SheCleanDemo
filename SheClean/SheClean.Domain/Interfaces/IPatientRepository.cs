using System.Collections;
using System.Collections.Generic;
using SheClean.Domain.Models;

namespace SheClean.Domain.Interfaces
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
    }
}