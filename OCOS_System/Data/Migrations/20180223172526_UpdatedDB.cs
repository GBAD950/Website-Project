using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OCOS_System.Data.Migrations
{
    public partial class UpdatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Business",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "StoreNum",
                table: "AspNetUsers",
                newName: "StoreNumber");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "AspNetUsers",
                newName: "NameOfBusiness");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "StoreNumber",
                table: "AspNetUsers",
                newName: "StoreNum");

            migrationBuilder.RenameColumn(
                name: "NameOfBusiness",
                table: "AspNetUsers",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Business",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
