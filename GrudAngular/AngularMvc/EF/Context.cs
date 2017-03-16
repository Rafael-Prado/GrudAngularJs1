
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using AngularMvc.Models;

namespace AngularMvc.EF
{
    public class Context: DbContext
    {
        public Context()
            : base("ProjetoDeTeste")
        {
            
        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}