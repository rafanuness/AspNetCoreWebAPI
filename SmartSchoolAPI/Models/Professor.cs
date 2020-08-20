using System.Collections.Generic;

namespace SmartSchoolAPI.Models
{
    public class Professor
    {
        public Professor()
        {
            
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplina { get; set; }
    }
}