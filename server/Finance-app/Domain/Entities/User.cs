using Domain.Enums;
using Domain.Utils;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(150)]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [MaxLength(20)]
    public string? Role { get; set; }

    public DateTime CreatedAt { get; set; }

    // Relação com Expenses (um usuário tem muitos gastos)
    public ICollection<Expense> Expenses { get; set; }

    public User()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        Role = Utils.Utils.GetDescription(UserRole.USER);
        Expenses = new List<Expense>();
    }

    public User(string name, string email, string passwordHash, string? role = "User")
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
        CreatedAt = DateTime.UtcNow;
        Expenses = new List<Expense>();
    }
}