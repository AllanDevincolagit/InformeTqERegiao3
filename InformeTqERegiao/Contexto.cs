using Microsoft.EntityFrameworkCore;
using InformeTqERegiao.Entidades;

namespace InformeTqERegiao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Permissao> permissao { get; set; }
        public DbSet<Permissao_Usuario> permisao_usuario { get; set; }
        public DbSet<ProblemaDialogocs> problemaDialogocs { get; set; }
        public DbSet<Cidades> cidades { get; set; } 


    }
}
