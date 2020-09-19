using Microsoft.AspNetCore.Mvc;
using SheClean.Application.Interfaces;
using SheClean.Application.ViewModels;

namespace SheCleanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PatientViewModel patientViewModel)
        {
            _patientService.Create(patientViewModel);

            return Ok(patientViewModel);
        }
    }
}
