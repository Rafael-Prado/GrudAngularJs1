
using System;

namespace AngularMvc.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}