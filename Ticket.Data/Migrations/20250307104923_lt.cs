﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket.Data.Migrations
{
    public partial class lt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "Event");
        }
    }
}
