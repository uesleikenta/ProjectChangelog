using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChangelogProject.Migrations {
	public partial class CreateTableClient : Migration {
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
					name: "Clients",
					columns: table => new {
						Id = table.Column<string>(type: "text", nullable: false),
						Name = table.Column<string>(type: "text", nullable: false),
						CreatedBy = table.Column<string>(type: "text", nullable: false),
						CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
						UpdatedBy = table.Column<string>(type: "text", nullable: false),
						UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
					},
					constraints: table => {
						table.PrimaryKey("PK_Clients", x => x.Id);
					});
		}

		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropTable(
					name: "Clients");
		}
	}
}
