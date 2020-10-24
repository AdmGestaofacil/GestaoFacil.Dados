using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestaoFacil.Dados
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            _connectionString = Util.GetConnectionString("Base");
        }

        private string _connectionString;
        public long idUsuario = 0;
        public Context()
        {
            _connectionString = Util.GetConnectionString("Base");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Cartao> Cartao { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<TipoDespesa> TipoDespesas { get; set; }
        public DbSet<Vale> Vales { get; set; }
        public DbSet<TipoPagamento> TipoPagamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Situacao> Situacao { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Faturamento> Faturamento { get; set; }
        public DbSet<ItemFaturamento> ItemFaturamento { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Criando perfil padão do sistema
            modelBuilder.Entity<Perfil>().HasData(new Dados.Modelos.Perfil { PerfilId = 1,  Descricao = "MASTER",TipoPerfil = 0});
            modelBuilder.Entity<Perfil>().HasData(new Dados.Modelos.Perfil { PerfilId = 2, Descricao = "ADMINISTRADOR", TipoPerfil = 1 });
            modelBuilder.Entity<Perfil>().HasData(new Dados.Modelos.Perfil { PerfilId = 3, Descricao = "COLABORADOR", TipoPerfil = 2 });
            #endregion

            #region Criando um funcionario de sistema, nao de aparecer na tela
            modelBuilder.Entity<Funcionario>().HasData(
                new Dados.Modelos.Funcionario
                { 
                    FuncionarioId= 1, 
                    Nome = "padrao", 
                    cpf = "32563614805" ,
                    DataCadastro=null,
                    DataNascimento=DateTime.Now,
                    Salario=0,
                    Celular=null,
                    TelResidencial=null,
                    Email="",
                    Ativo=false,
                
                });
            #endregion

            #region  Criação dos usuarios que são comuns e padrão
            //criando usuario padrão
            modelBuilder.Entity<Usuario>().HasData(
                    new Dados.Modelos.Usuario {
                        UsuarioId = 1,
                        Login = "ADMINISTRADOR",
                        Senha = "123123",
                        FuncionarioId = 1,
                        DataCadastro = DateTime.Now,
                        PerfilId = 2,
                        Situacao = true,
                        ConfirmaSenha = "",
                        IsGrupo = true
                    });
                    modelBuilder.Entity<Usuario>().HasData(
                    new Dados.Modelos.Usuario
                    {
                        UsuarioId = 2,
                        Login = "COLABORADOR",
                        Senha = "123123",
                        FuncionarioId = 1,
                        DataCadastro = DateTime.Now,
                        PerfilId = 3,
                        Situacao = true,
                        ConfirmaSenha = "",
                        IsGrupo = true
                    });
            modelBuilder.Entity<Usuario>().HasData(
                    new Dados.Modelos.Usuario
                    {
                        UsuarioId = 3,
                        Login = "MASTER",
                        Senha = "123123",
                        FuncionarioId = 1,
                        DataCadastro = DateTime.Now,
                        PerfilId = 1,
                        Situacao = true,
                        ConfirmaSenha = "",
                        IsGrupo = true
                    });
            #endregion

            #region Criando os módulos padrão do sistema
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 1, Nome = "mnuAgenda", Descricao = "menu agenda" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 2, Nome = "mnuCadastro", Descricao = "menu de cadastro" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 3, Nome = "mnuFinanceiro", Descricao = "menu de financeiro" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 4, Nome = "mnuRelatorios", Descricao = "menu relatorios" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 5, Nome = "mnuferramentas", Descricao = "menu de ferramentas" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 6, Nome = "mnuferramentas", Descricao = "menu sistema" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 7, Nome = "mnulateral", Descricao = "menu lateral" });
            modelBuilder.Entity<Modulo>().HasData(new Dados.Modelos.Modulo { ModuloId = 8, Nome = "mnusistema", Descricao = "menu de sistema" });
            #endregion
            #region Criando os componentes de cada módulo.
                #region  Módulo cadastro
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 1, Nome = "mnuItemProfissionais", Descricao = "Cadastro de Profissionais", ModuloId=2});
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 2, Nome = "mnuItemClientes", Descricao = "Cadastro de cliente", ModuloId = 2 });
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 3, Nome = "mnuItemServicos", Descricao = "Cadastro de serviço", ModuloId = 2 });
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 4, Nome = "mnuItemProdutos", Descricao = "Cadastro de produtos", ModuloId = 2 });
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 5, Nome = "mnuItemCrtDebCred", Descricao = "Cadastro de cartão", ModuloId = 2 });
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 6, Nome = "mnuItemComissao", Descricao = "Cadastro de comissão", ModuloId = 2 });
                modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 7, Nome = "mnuItemCtlVale", Descricao = "Cadastro de vale", ModuloId = 2 });
            #endregion

            #region Componentes do módulo menu sistema 
            modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 8, Nome = "mnuItemCadastroUsuarios", Descricao = "Cadastro de usuários", ModuloId = 8 });
            #endregion

            #region  Componentes do módulo Financeiro
            modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 9, Nome = "mnuItemDespesas", Descricao = "Cadastro de despesa", ModuloId = 3 });
            #endregion
            #region   Módulo Faturamento
            modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 10, Nome = "mnuItemFaturamento", Descricao = "Relatórios gerencias", ModuloId = 4 });
            modelBuilder.Entity<Componente>().HasData(new Dados.Modelos.Componente { ComponenteId = 11, Nome = "submenuitem", Descricao = "Relatório de faturamento", ModuloId = 4 });
            #endregion

            #region Componentes do módulo  agenda atendimento tela princial
            #endregion
            // falta outros...
            #endregion


        }

    }
}
