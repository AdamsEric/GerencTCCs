using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string AlunoNome { get; set; }
        public string AlunoMatricula { get; set; }
        public string AlunoTelefone { get; set; }
        public int AlunoCursoID { get; set; }
        public string AlunoCursoNome { get; set; }
        public int AlunoUnidadeID { get; set; }
        public string AlunoUnidadeNome { get; set; }
    }
}
