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
        public string TCCArea { get; set; }
        public string TCCSubarea { get; set; }
        public string TCCEspecialidade { get; set; }
        public int TCCPaginas { get; set; }
        public string TCCResumo { get; set; }
        public DateTime TCCData { get; set; }
        public int TCCSalaID { get; set; }
        public int TCCAlunoID { get; set; }
        public int TCCOrientadorID { get; set; }
        public int TCCBancaID { get; set; }
        public int TCCBancaProfessor1 { get; set; }
        public int TCCBancaProfessor2 { get; set; }
    }
}
