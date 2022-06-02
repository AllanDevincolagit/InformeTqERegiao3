using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Entidades
{
    public class Usuarios
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public Cidades Cidades { get; set; }
        public string Telefone { get; set; }
       
    }
}
