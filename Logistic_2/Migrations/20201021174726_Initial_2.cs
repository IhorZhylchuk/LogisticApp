using Microsoft.EntityFrameworkCore.Migrations;

namespace Logistic_2.Migrations
{
    public partial class Initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a15be3c1-aa45-4af6-bd17-00bd9376e455",
                column: "ConcurrencyStamp",
                value: "626a87bf-9204-4a17-9a1a-d3bf17297ab8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "1400f51b-e115-459e-89a8-79736f62ca81");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15be3c1-aa45-4af6-bd17-00bd9376e455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45f0f78d-685b-47c5-bf14-544fa67d4ac3", "AQAAAAEAACcQAAAAENXngb3OnG6F649ewPuqpbC4F0EsN5P9dpbs7PoHY9jUmdwda94IBDfvavr5QmLXPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05e02543-acb6-4c7c-8aff-dbed7156a086", "AQAAAAEAACcQAAAAEGBGJEGp8BQ4oWXDBVZXUDlaKd97SyeghidppYj8ybwnpMb8nau6LK9PrEli+5WE/Q==" });
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a15be3c1-aa45-4af6-bd17-00bd9376e455",
                column: "ConcurrencyStamp",
                value: "d624d780-77d1-48b2-9182-28a6e0a1af5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                column: "ConcurrencyStamp",
                value: "ed0404be-4eff-48fe-b33d-3a68d53dd504");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15be3c1-aa45-4af6-bd17-00bd9376e455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03e44ade-8ffb-4755-99ca-fb9827ec94ce", "AQAAAAEAACcQAAAAEGA2mhX+2rQGFLD5xR5+td1LL0SYCQfKsSTerFl548hddFBiCsTYr6BfZ03EYvqXFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09674090-1cef-40fc-8a15-b3ee13e31fe1", "AQAAAAEAACcQAAAAEHIDOvpWgr6830zQkQU1ZgCOk7Z8TX/nWS/ubkGao7AbNOSrTqIhlpjsWXfaSAG0aw==" });
        }
    }
}
