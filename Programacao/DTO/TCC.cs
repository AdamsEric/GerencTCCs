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
        public string TCCDescricao { get; set; }
        public string TCCTema { get; set; }
        public DateTime TCCData { get; set; }
        public int TCCSalaID { get; set; }
        public int TCCAlunoID { get; set; }
        public int TCCBancaID { get; set; }
    }
}
