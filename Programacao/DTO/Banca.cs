using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Banca
    {
        public int BancaID { get; set; }
        public int BancaProfessorID { get; set; }
        public string BancaProfessorNome { get; set; }
        public int BancaTCCID { get; set; }
        public int BancaBancaProfessorID { get; set; }
    }
}
