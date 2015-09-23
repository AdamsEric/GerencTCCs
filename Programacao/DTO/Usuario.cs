using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioMatricula { get; set; }
        public int UsuarioGrupoID { get; set; }
    }
}
