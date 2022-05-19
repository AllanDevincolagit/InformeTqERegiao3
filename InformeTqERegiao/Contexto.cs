using Microsoft.EntityFrameworkCore;
using InformeTqERegiao.Models;

namespace InformeTqERegiao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<InformeProblema> InformeProblem { get; set; }
        
        /*public DbSet<InformeProblema> SOBRENOME { get; set; }
        public DbSet<InformeProblema> CPF { get; set; }
        public DbSet<InformeProblema> TELEFONE { get; set; }
        public DbSet<InformeProblema> EMAIL { get; set; }
        public DbSet<InformeProblema> OCORRIDO { get; set; }*/

    }
}
