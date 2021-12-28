using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdPessoa);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    IdVendedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.IdPessoa);
                    table.ForeignKey(
                        name: "FK_Vendedor_Pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalTable: "Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrazoEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    ClienteIdPessoa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteIdPessoa",
                        column: x => x.ClienteIdPessoa,
                        principalTable: "Cliente",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVendedor = table.Column<int>(type: "int", nullable: false),
                    VendedorIdPessoa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_Produto_Vendedor_VendedorIdPessoa",
                        column: x => x.VendedorIdPessoa,
                        principalTable: "Vendedor",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemPedido",
                columns: table => new
                {
                    IdItemPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    ProdutoIdPedido = table.Column<int>(type: "int", nullable: true),
                    IdPedido = table.Column<int>(type: "int", nullable: false),
                    PedidoIdPedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPedido", x => x.IdItemPedido);
                    table.ForeignKey(
                        name: "FK_ItemPedido_Pedido_PedidoIdPedido",
                        column: x => x.PedidoIdPedido,
                        principalTable: "Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemPedido_Pedido_ProdutoIdPedido",
                        column: x => x.ProdutoIdPedido,
                        principalTable: "Pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoIdPedido",
                table: "ItemPedido",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_ProdutoIdPedido",
                table: "ItemPedido",
                column: "ProdutoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteIdPessoa",
                table: "Pedido",
                column: "ClienteIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_VendedorIdPessoa",
                table: "Produto",
                column: "VendedorIdPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPedido");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
