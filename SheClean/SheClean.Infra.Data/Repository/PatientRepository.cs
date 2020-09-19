using System.Collections.Generic;
using System.Linq;
using SheClean.Domain.Interfaces;
using SheClean.Domain.Models;
using SheClean.Infra.Data.Context;

namespace SheClean.Infra.Data.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private SheDbContext _ctx;

        public PatientRepository(SheDbContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Patient> GetPatients()
        {
            return _ctx.Patients;
        }

        public void Add(Patient patient)
        {
            _ctx.Patients.Add(patient);
            _ctx.SaveChanges();
        }
    }
}