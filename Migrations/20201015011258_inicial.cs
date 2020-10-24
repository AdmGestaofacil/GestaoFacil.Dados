using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoFacil.Dados.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartao",
                columns: table => new
                {
                    CartaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    Taxa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    permititParcelamentoNoCartao = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartao", x => x.CartaoId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Cpf = table.Column<string>(maxLength: 11, nullable: true),
                    Responsavel = table.Column<string>(maxLength: 50, nullable: true),
                    Informacoes = table.Column<string>(nullable: true),
                    Sexo = table.Column<bool>(nullable: true),
                    AceitoNotificaoes = table.Column<bool>(nullable: true),
                    DtNascimento = table.Column<DateTime>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(maxLength: 100, nullable: true),
                    NomeFantasia = table.Column<string>(maxLength: 100, nullable: true),
                    CpfCnpj = table.Column<string>(maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    cpf = table.Column<string>(maxLength: 14, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Celular = table.Column<string>(maxLength: 11, nullable: true),
                    TelResidencial = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.FuncionarioId);
                });

            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    ModuloId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.ModuloId);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    PerfilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 100, nullable: true),
                    TipoPerfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.PerfilId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 250, nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Custo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MargemRevenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    ServicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 250, nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDescontinuado = table.Column<bool>(nullable: false),
                    DuracaoEmMinutos = table.Column<int>(nullable: false),
                    Comissao = table.Column<float>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DtAtualizacao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.ServicoId);
                });

            migrationBuilder.CreateTable(
                name: "Situacao",
                columns: table => new
                {
                    SituacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSituacao = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacao", x => x.SituacaoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoDespesa",
                columns: table => new
                {
                    TipoDespesaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDespesa", x => x.TipoDespesaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamento",
                columns: table => new
                {
                    TipoPagamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 100, nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamento", x => x.TipoPagamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Despesa",
                columns: table => new
                {
                    DespesaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    Documento = table.Column<string>(maxLength: 44, nullable: true),
                    Observacao = table.Column<string>(maxLength: 500, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoDespesaId = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataVencimento = table.Column<DateTime>(nullable: true),
                    DespesaIsPaga = table.Column<bool>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: true),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesa", x => x.DespesaId);
                    table.ForeignKey(
                        name: "FK_Despesa_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Despesa_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vale",
                columns: table => new
                {
                    ValeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vale", x => x.ValeId);
                    table.ForeignKey(
                        name: "FK_Vale_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Componentes",
                columns: table => new
                {
                    ComponenteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    ModuloId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componentes", x => x.ComponenteId);
                    table.ForeignKey(
                        name: "FK_Componentes_Modulo_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "Modulo",
                        principalColumn: "ModuloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 100, nullable: false),
                    Senha = table.Column<string>(maxLength: 100, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    ConfirmaSenha = table.Column<string>(maxLength: 100, nullable: false),
                    IsGrupo = table.Column<bool>(nullable: false),
                    Situacao = table.Column<bool>(nullable: false),
                    Visualisar = table.Column<bool>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: false),
                    PerfilId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "PerfilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturamento",
                columns: table => new
                {
                    FaturamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataMovimentacao = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Cancelado = table.Column<bool>(nullable: false),
                    Origem = table.Column<int>(nullable: false),
                    TipoPgtoId = table.Column<int>(nullable: false),
                    TipoPagamentoId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    ClienteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturamento", x => x.FaturamentoId);
                    table.ForeignKey(
                        name: "FK_Faturamento_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faturamento_TipoPagamento_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TipoPagamento",
                        principalColumn: "TipoPagamentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faturamento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemFaturamento",
                columns: table => new
                {
                    ItemFaturamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bruto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BrutoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LiquidoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServicoId = table.Column<int>(nullable: false),
                    FaturamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFaturamento", x => x.ItemFaturamentoId);
                    table.ForeignKey(
                        name: "FK_ItemFaturamento_Faturamento_FaturamentoId",
                        column: x => x.FaturamentoId,
                        principalTable: "Faturamento",
                        principalColumn: "FaturamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemFaturamento_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Funcionario",
                columns: new[] { "FuncionarioId", "Ativo", "Celular", "DataCadastro", "DataNascimento", "Email", "Nome", "Salario", "TelResidencial", "cpf" },
                values: new object[] { 1, false, null, null, new DateTime(2020, 10, 14, 22, 12, 57, 923, DateTimeKind.Local).AddTicks(5927), "", "padrao", 0m, null, "32563614805" });

            migrationBuilder.InsertData(
                table: "Modulo",
                columns: new[] { "ModuloId", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, "menu agenda", "mnuAgenda" },
                    { 2, "menu de cadastro", "mnuCadastro" },
                    { 3, "menu de financeiro", "mnuFinanceiro" },
                    { 4, "menu relatorios", "mnuRelatorios" },
                    { 5, "menu de ferramentas", "mnuferramentas" },
                    { 6, "menu sistema", "mnuferramentas" },
                    { 7, "menu lateral", "mnulateral" },
                    { 8, "menu de sistema", "mnusistema" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "PerfilId", "Descricao", "TipoPerfil" },
                values: new object[,]
                {
                    { 1, "MASTER", 0 },
                    { 2, "ADMINISTRADOR", 1 },
                    { 3, "COLABORADOR", 2 }
                });

            migrationBuilder.InsertData(
                table: "Componentes",
                columns: new[] { "ComponenteId", "Descricao", "ModuloId", "Nome" },
                values: new object[,]
                {
                    { 1, "Cadastro de Profissionais", 2, "mnuItemProfissionais" },
                    { 2, "Cadastro de cliente", 2, "mnuItemClientes" },
                    { 3, "Cadastro de serviço", 2, "mnuItemServicos" },
                    { 4, "Cadastro de produtos", 2, "mnuItemProdutos" },
                    { 5, "Cadastro de cartão", 2, "mnuItemCrtDebCred" },
                    { 6, "Cadastro de comissão", 2, "mnuItemComissao" },
                    { 7, "Cadastro de vale", 2, "mnuItemCtlVale" },
                    { 9, "Cadastro de despesa", 3, "mnuItemDespesas" },
                    { 10, "Relatórios gerencias", 4, "mnuItemFaturamento" },
                    { 11, "Relatório de faturamento", 4, "submenuitem" },
                    { 8, "Cadastro de usuários", 8, "mnuItemCadastroUsuarios" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "ConfirmaSenha", "DataCadastro", "FuncionarioId", "IsGrupo", "Login", "PerfilId", "Senha", "Situacao", "Visualisar" },
                values: new object[,]
                {
                    { 3, "", new DateTime(2020, 10, 14, 22, 12, 57, 926, DateTimeKind.Local).AddTicks(3385), 1, true, "MASTER", 1, "123123", true, false },
                    { 1, "", new DateTime(2020, 10, 14, 22, 12, 57, 925, DateTimeKind.Local).AddTicks(9833), 1, true, "ADMINISTRADOR", 2, "123123", true, false },
                    { 2, "", new DateTime(2020, 10, 14, 22, 12, 57, 926, DateTimeKind.Local).AddTicks(3144), 1, true, "COLABORADOR", 3, "123123", true, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Componentes_ModuloId",
                table: "Componentes",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_FornecedorId",
                table: "Despesa",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Despesa_FuncionarioId",
                table: "Despesa",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturamento_ClienteID",
                table: "Faturamento",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Faturamento_TipoPagamentoId",
                table: "Faturamento",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturamento_UsuarioId",
                table: "Faturamento",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemFaturamento_FaturamentoId",
                table: "ItemFaturamento",
                column: "FaturamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemFaturamento_ServicoId",
                table: "ItemFaturamento",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_FuncionarioId",
                table: "Usuario",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Vale_FuncionarioId",
                table: "Vale",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cartao");

            migrationBuilder.DropTable(
                name: "Componentes");

            migrationBuilder.DropTable(
                name: "Despesa");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "ItemFaturamento");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Situacao");

            migrationBuilder.DropTable(
                name: "TipoDespesa");

            migrationBuilder.DropTable(
                name: "Vale");

            migrationBuilder.DropTable(
                name: "Modulo");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Faturamento");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "TipoPagamento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
