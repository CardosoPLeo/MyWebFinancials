using Microsoft.EntityFrameworkCore.Migrations;

namespace Webfinacials.Migrations
{
    public partial class Create_DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CadContas_Credor_CredorIdCredor",
                table: "CadContas");

            migrationBuilder.DropForeignKey(
                name: "FK_LancamentoDeContas_CadContas_CadContasIdConta",
                table: "LancamentoDeContas");

            migrationBuilder.DropForeignKey(
                name: "FK_LancamentoDeContas_Cliente_ClienteIdCliente",
                table: "LancamentoDeContas");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteIdCliente",
                table: "LancamentoDeContas",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "CadContasIdConta",
                table: "LancamentoDeContas",
                newName: "CadContasId");

            migrationBuilder.RenameColumn(
                name: "IdLancamento",
                table: "LancamentoDeContas",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_LancamentoDeContas_ClienteIdCliente",
                table: "LancamentoDeContas",
                newName: "IX_LancamentoDeContas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_LancamentoDeContas_CadContasIdConta",
                table: "LancamentoDeContas",
                newName: "IX_LancamentoDeContas_CadContasId");

            migrationBuilder.RenameColumn(
                name: "IdCredor",
                table: "Credor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CredorIdCredor",
                table: "CadContas",
                newName: "CredorId");

            migrationBuilder.RenameColumn(
                name: "IdConta",
                table: "CadContas",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_CadContas_CredorIdCredor",
                table: "CadContas",
                newName: "IX_CadContas_CredorId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Desconto",
                table: "LancamentoDeContas",
                type: "decimal (18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Acrescimo",
                table: "LancamentoDeContas",
                type: "decimal (18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "CadContas",
                type: "decimal (18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_CadContas_Credor_CredorId",
                table: "CadContas",
                column: "CredorId",
                principalTable: "Credor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LancamentoDeContas_CadContas_CadContasId",
                table: "LancamentoDeContas",
                column: "CadContasId",
                principalTable: "CadContas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LancamentoDeContas_Cliente_ClienteId",
                table: "LancamentoDeContas",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CadContas_Credor_CredorId",
                table: "CadContas");

            migrationBuilder.DropForeignKey(
                name: "FK_LancamentoDeContas_CadContas_CadContasId",
                table: "LancamentoDeContas");

            migrationBuilder.DropForeignKey(
                name: "FK_LancamentoDeContas_Cliente_ClienteId",
                table: "LancamentoDeContas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "LancamentoDeContas",
                newName: "ClienteIdCliente");

            migrationBuilder.RenameColumn(
                name: "CadContasId",
                table: "LancamentoDeContas",
                newName: "CadContasIdConta");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LancamentoDeContas",
                newName: "IdLancamento");

            migrationBuilder.RenameIndex(
                name: "IX_LancamentoDeContas_ClienteId",
                table: "LancamentoDeContas",
                newName: "IX_LancamentoDeContas_ClienteIdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_LancamentoDeContas_CadContasId",
                table: "LancamentoDeContas",
                newName: "IX_LancamentoDeContas_CadContasIdConta");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Credor",
                newName: "IdCredor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "IdCliente");

            migrationBuilder.RenameColumn(
                name: "CredorId",
                table: "CadContas",
                newName: "CredorIdCredor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CadContas",
                newName: "IdConta");

            migrationBuilder.RenameIndex(
                name: "IX_CadContas_CredorId",
                table: "CadContas",
                newName: "IX_CadContas_CredorIdCredor");

            migrationBuilder.AlterColumn<decimal>(
                name: "Desconto",
                table: "LancamentoDeContas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal (18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Acrescimo",
                table: "LancamentoDeContas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal (18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "CadContas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal (18,4)");

            migrationBuilder.AddForeignKey(
                name: "FK_CadContas_Credor_CredorIdCredor",
                table: "CadContas",
                column: "CredorIdCredor",
                principalTable: "Credor",
                principalColumn: "IdCredor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LancamentoDeContas_CadContas_CadContasIdConta",
                table: "LancamentoDeContas",
                column: "CadContasIdConta",
                principalTable: "CadContas",
                principalColumn: "IdConta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LancamentoDeContas_Cliente_ClienteIdCliente",
                table: "LancamentoDeContas",
                column: "ClienteIdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
