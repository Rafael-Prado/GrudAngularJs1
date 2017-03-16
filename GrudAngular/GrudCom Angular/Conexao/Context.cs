
using System.Data.Entity;
using GrudComAngular.Models;
namespace GrudCom_Angular.Conexao
{
    public class Context: DbContext
    {
        public Context()
            : base("ProjetoDeTeste")
        {
            
        }

        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

       

    }
}