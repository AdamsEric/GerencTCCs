using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sala
    {
        public int SalaID { get; set; }
        public string SalaNome { get; set; }
        public string SalaDescricao { get; set; }
        public int SalaUnidadeID { get; set; }
        public string SalaUnidadeNome { get; set; }
        public int SalaSalaTipoID { get; set; }
        public string SalaSalaTipoNome { get; set; }
    }
}
