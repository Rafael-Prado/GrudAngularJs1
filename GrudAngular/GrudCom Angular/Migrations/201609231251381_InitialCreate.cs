namespace GrudCom_Angular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Rua = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Complemento = c.String(),
                        Numero = c.Int(nullable: false),
                        PessoaFisica_PessoaFisicaId = c.Int(),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.PessoaFisicas", t => t.PessoaFisica_PessoaFisicaId)
                .Index(t => t.PessoaFisica_PessoaFisicaId);
            
            CreateTable(
                "dbo.PessoaFisicas",
                c => new
                    {
                        PessoaFisicaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                        Rg = c.String(),
                    })
                .PrimaryKey(t => t.PessoaFisicaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enderecoes", "PessoaFisica_PessoaFisicaId", "dbo.PessoaFisicas");
            DropIndex("dbo.Enderecoes", new[] { "PessoaFisica_PessoaFisicaId" });
            DropTable("dbo.PessoaFisicas");
            DropTable("dbo.Enderecoes");
        }
    }
}
