using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Entidades
{
    public class Permissao_Usuario
    {
        public int id { get; set; }
        public int UsuarioID { get; set; }
        public int PermissaoID { get; set; }
        public Permissao Permissao { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
