﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Pi.Univesp.Data.Migrations
{
    public partial class fixAlunos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Nota",
                table: "Alunos",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Alunos");
        }
    }
}
