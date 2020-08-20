using Microsoft.AspNetCore.Mvc;

namespace SmartSchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        
        public ProfessorController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professores : Marcos");
        }
        
    }

}