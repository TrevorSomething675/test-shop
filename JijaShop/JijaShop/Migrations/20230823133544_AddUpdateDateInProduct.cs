﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JijaShop.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdateDateInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Products");
        }
    }
}
