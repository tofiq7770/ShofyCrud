﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendMiniTask.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductImages");

            migrationBuilder.AddColumn<int>(
                name: "ProductImageId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductImageId",
                table: "Products",
                column: "ProductImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductImages_ProductImageId",
                table: "Products",
                column: "ProductImageId",
                principalTable: "ProductImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductImages_ProductImageId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductImageId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductImageId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}