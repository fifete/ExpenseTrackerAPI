using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.Models
{
    [Keyless]
    public class CategoryExpenseDto
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal SpendingAmount { get; set; }
    }
}
