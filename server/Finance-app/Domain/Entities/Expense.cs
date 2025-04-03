// Domain/Entities/Expense.cs
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Expense
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Description { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Amount { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [MaxLength(50)]
    public string Category { get; set; } 

    // Chave estrangeira para User
    public Guid UserId { get; set; }
    public User User { get; set; } 

    public Expense()
    {
        Id = Guid.NewGuid();
    }

    public Expense(string description, decimal amount, DateTime date, string category, Guid userId)
    {
        Id = Guid.NewGuid();
        Description = description;
        Amount = amount;
        Date = date;
        Category = category;
        UserId = userId;
    }
}