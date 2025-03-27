using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecretosParaContar.Data.Migrations
{
    /// <inheritdoc />
    public partial class LibroUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Libro",
                newName: "PdfLink");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Autor",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "AudiobookLink",
                table: "Libro",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Libro",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DownloadLink",
                table: "Libro",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Editorial",
                table: "Libro",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Libro",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudiobookLink",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "DownloadLink",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "Editorial",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Libro");

            migrationBuilder.RenameColumn(
                name: "PdfLink",
                table: "Libro",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Autor",
                newName: "name");
        }
    }
}
