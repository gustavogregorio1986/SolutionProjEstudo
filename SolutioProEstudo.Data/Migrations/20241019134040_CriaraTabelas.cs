using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutioProEstudo.Data.Migrations
{
    public partial class CriaraTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Funcionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_Empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Funcionarioe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Empresa_tb_Funcionario_Id_Funcionarioe",
                        column: x => x.Id_Funcionarioe,
                        principalTable: "tb_Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Empresa = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Cliente_tb_Empresa_Id_Empresa",
                        column: x => x.Id_Empresa,
                        principalTable: "tb_Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Cliente_Id_Empresa",
                table: "tb_Cliente",
                column: "Id_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Empresa_Id_Funcionarioe",
                table: "tb_Empresa",
                column: "Id_Funcionarioe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Cliente");

            migrationBuilder.DropTable(
                name: "tb_Empresa");

            migrationBuilder.DropTable(
                name: "tb_Funcionario");
        }
    }
}
