using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;

namespace SheClean.MVC.Controllers
{
    
    [Authorize]
    public class PatientController : Controller
    {
        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        // GET
        public IActionResult Index()
        {
            PatientViewModel model = _patientService.GetPatients();
            return View(model);
        }
    }
}