using Microsoft.EntityFrameworkCore.Migrations;

namespace Pi.Univesp.Data.Migrations
{
    public partial class fixNotaValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ValorNota",
                table: "Nota",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorNota",
                table: "Nota");
        }
    }
}
