using Microsoft.EntityFrameworkCore;
using SheClean.Domain.Models;

namespace SheClean.Infra.Data.Context
{
    public class SheDbContext :DbContext
    {
        public SheDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Patient> Patients { get; set; }
    }
}