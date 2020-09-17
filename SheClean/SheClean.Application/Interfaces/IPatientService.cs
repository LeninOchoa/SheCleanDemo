using System.Collections;
using System.Collections.Generic;
using SheClean.Application.ViewModels;


namespace SheClean.Application.Interfaces
{
    public interface IPatientService
    {
        PatientViewModel GetCourses();
    }
}