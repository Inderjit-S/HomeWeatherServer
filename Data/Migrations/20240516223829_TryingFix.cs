using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class TryingFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Playlists",
                newName: "TotalSongs");

            migrationBuilder.RenameColumn(
                name: "Creator",
                table: "Playlists",
                newName: "Title");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Name",
                table: "Playlists",
                newName: "IX_Playlists_TotalSongs");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Creator",
                table: "Playlists",
                newName: "IX_Playlists_Title");

            migrationBuilder.AddColumn<string>(
                name: "Album",
                table: "Songs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Playlists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_Album",
                table: "Songs",
                column: "Album");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_Owner",
                table: "Playlists",
                column: "Owner");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Songs_Album",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_Owner",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "Album",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Playlists");

            migrationBuilder.RenameColumn(
                name: "TotalSongs",
                table: "Playlists",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Playlists",
                newName: "Creator");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_TotalSongs",
                table: "Playlists",
                newName: "IX_Playlists_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Title",
                table: "Playlists",
                newName: "IX_Playlists_Creator");
        }
    }
}
