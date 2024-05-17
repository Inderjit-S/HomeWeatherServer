using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class LastAttempt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Songs_Album",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_TotalSongs",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "Album",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "TotalSongs",
                table: "Playlists");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Playlists",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "Playlists",
                newName: "Creator");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Title",
                table: "Playlists",
                newName: "IX_Playlists_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Owner",
                table: "Playlists",
                newName: "IX_Playlists_Creator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Playlists",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Creator",
                table: "Playlists",
                newName: "Owner");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Name",
                table: "Playlists",
                newName: "IX_Playlists_Title");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_Creator",
                table: "Playlists",
                newName: "IX_Playlists_Owner");

            migrationBuilder.AddColumn<string>(
                name: "Album",
                table: "Songs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TotalSongs",
                table: "Playlists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Songs_Album",
                table: "Songs",
                column: "Album");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_TotalSongs",
                table: "Playlists",
                column: "TotalSongs");
        }
    }
}
