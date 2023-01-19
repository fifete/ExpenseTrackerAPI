﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerAPI.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? UserIdTemp { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal MaxBudget { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal SpendingAmount { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Emoji { get; set; }
    }
}
