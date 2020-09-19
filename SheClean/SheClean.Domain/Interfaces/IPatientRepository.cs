using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SheClean.Domain.Models;

namespace SheClean.Domain.Interfaces
{
    public interface IPatientRepository
    {
        IQueryable<Patient> GetPatients();
        void Add(Patient patient);
    }
}