using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoFinal.Migrations
{
    public partial class PatiobaBdSquad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artesao",
                columns: table => new
                {
                    IdArtesao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeArtesao = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artesao", x => x.IdArtesao);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
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
                    ArtesaoIdArtesao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_Produto_Artesao_ArtesaoIdArtesao",
                        column: x => x.ArtesaoIdArtesao,
                        principalTable: "Artesao",
                        principalColumn: "IdArtesao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suporte",
                columns: table => new
                {
                    IdSuporte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suporte", x => x.IdSuporte);
                    table.ForeignKey(
                        name: "FK_Suporte_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteIdCliente = table.Column<int>(type: "int", nullable: false),
                    ProdutoIdProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.IdPedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Produto_ProdutoIdProduto",
                        column: x => x.ProdutoIdProduto,
                        principalTable: "Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteIdCliente",
                table: "Pedido",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ProdutoIdProduto",
                table: "Pedido",
                column: "ProdutoIdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_ArtesaoIdArtesao",
                table: "Produto",
                column: "ArtesaoIdArtesao");

            migrationBuilder.CreateIndex(
                name: "IX_Suporte_ClienteIdCliente",
                table: "Suporte",
                column: "ClienteIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Suporte");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Artesao");
        }
    }
}
