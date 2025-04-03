using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<User?> GetByEmailAsync(string email);
        Task<bool> CheckPasswordAsync(string email, string password);
        Task<User> CreateAsync(User user);
        //Task UpdateAsync(User user);
        //Task DeleteAsync(Guid id);
    }
}
