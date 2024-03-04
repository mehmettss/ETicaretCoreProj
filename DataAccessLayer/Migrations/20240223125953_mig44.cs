using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                    CREATE PROCEDURE GetProductsByCategoryId
                        @categoryId INT
                    AS
                    BEGIN
                        SELECT * FROM Products WHERE CategoryId = @categoryId;
                    END

                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP PROC GetProductsByCategoryId");
        }
    }
}
