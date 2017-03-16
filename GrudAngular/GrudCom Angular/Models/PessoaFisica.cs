using System.Collections.ObjectModel;

namespace GrudComAngular.Models
{
    public class PessoaFisica
    {
        public int PessoaFisicaId  { get; set; }
        public string Nome  { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public Collection<Endereco> Enderecos { get; set; }
    }
}