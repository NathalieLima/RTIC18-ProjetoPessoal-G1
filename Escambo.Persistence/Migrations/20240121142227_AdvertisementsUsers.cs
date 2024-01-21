using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escambo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdvertisementsUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaluations_Users_UserId",
                table: "Avaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_ReceiverId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Users_SenderId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Posters_Users_UserId",
                table: "Posters");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_UserAcceptedId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Users_UserRequiredId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserRequiredId",
                table: "Services",
                newName: "UserRequiredUserId");

            migrationBuilder.RenameColumn(
                name: "UserAcceptedId",
                table: "Services",
                newName: "UserAcceptedUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Services",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_UserRequiredId",
                table: "Services",
                newName: "IX_Services_UserRequiredUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_UserAcceptedId",
                table: "Services",
                newName: "IX_Services_UserAcceptedUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posters",
                newName: "PosterId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Messages",
                newName: "MessageId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Chats",
                newName: "ChatId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Avaluations",
                newName: "AvaluationId");

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "advertisements",
                columns: table => new
                {
                    AdvertisementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Credit = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Category = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisements", x => x.AdvertisementId);
                    table.ForeignKey(
                        name: "FK_advertisements_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_advertisements_UserId",
                table: "advertisements",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaluations_users_UserId",
                table: "Avaluations",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_users_ReceiverId",
                table: "Chats",
                column: "ReceiverId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_users_SenderId",
                table: "Chats",
                column: "SenderId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posters_users_UserId",
                table: "Posters",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_users_UserAcceptedUserId",
                table: "Services",
                column: "UserAcceptedUserId",
                principalTable: "users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_users_UserRequiredUserId",
                table: "Services",
                column: "UserRequiredUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaluations_users_UserId",
                table: "Avaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_users_ReceiverId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_users_SenderId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Posters_users_UserId",
                table: "Posters");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_users_UserAcceptedUserId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_users_UserRequiredUserId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "advertisements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserRequiredUserId",
                table: "Services",
                newName: "UserRequiredId");

            migrationBuilder.RenameColumn(
                name: "UserAcceptedUserId",
                table: "Services",
                newName: "UserAcceptedId");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Services",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Services_UserRequiredUserId",
                table: "Services",
                newName: "IX_Services_UserRequiredId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_UserAcceptedUserId",
                table: "Services",
                newName: "IX_Services_UserAcceptedId");

            migrationBuilder.RenameColumn(
                name: "PosterId",
                table: "Posters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "Messages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ChatId",
                table: "Chats",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AvaluationId",
                table: "Avaluations",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaluations_Users_UserId",
                table: "Avaluations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_ReceiverId",
                table: "Chats",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Users_SenderId",
                table: "Chats",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posters_Users_UserId",
                table: "Posters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_UserAcceptedId",
                table: "Services",
                column: "UserAcceptedId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Users_UserRequiredId",
                table: "Services",
                column: "UserRequiredId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
