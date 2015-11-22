using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TCC
    {
        public int TCCID { get; set; }
        public string TCCTitulo { get; set; }
        public int TCCAlunoID { get; set; }
        public string TCCAlunoNome { get; set; }
        public int TCCOrientadorID { get; set; }
        public string TCCOrientadorNome { get; set; }
        public string TCCGrandeArea { get; set; }
        public string TCCArea { get; set; }
        public string TCCSubarea { get; set; }
        public string TCCEspecialidade { get; set; }
        public int TCCPaginas { get; set; }
        public string TCCResumo { get; set; }
        public DateTime TCCData { get; set; }
        public int TCCSalaID { get; set; }
        public string TCCSalaNome { get; set; }
        public string TCCUnidade { get; set; }
    }
}
