using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTrackerAPI.Migrations
{
    public partial class Add_categExpense_view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW category_expenses AS
            SELECT c.id, SUM(e.amount) as SpendingAmount
            FROM categories c
            LEFT JOIN expenses e ON c.id = e.category_id
            GROUP BY c.id;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
