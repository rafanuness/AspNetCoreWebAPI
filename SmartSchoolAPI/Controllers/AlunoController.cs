using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartSchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        
        public List<Aluno> Alunos = new List<Aluno>() {

            new Aluno() {
                Id = 1,
                Nome = "Rafael",
                Sobrenome = "Nunes",
                Telefone = "12312123"

            },
            new Aluno() {
                Id = 2,
                Nome = "Barbara",
                Sobrenome = "Nunes",
                Telefone = "34343333"

            },
            new Aluno() {
                Id = 3,
                Nome = "Bruna",
                Sobrenome = "Nunes",
                Telefone = "533323233"

            }

        };
        

        public AlunoController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null) return BadRequest("Aluno não encontrado.");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
        public IActionResult GetByNome(string nome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome));

            if (aluno == null) return BadRequest("Aluno não encontrado.");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {           
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(Aluno aluno)
        {           
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {           
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {           
            return Ok();
        }
        
    }

}