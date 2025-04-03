using AutoMapper.Internal;
using Domain.Dtos.Request;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data.Repositories;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Application.Services
{ 
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(TokenService tokenService, IUserRepository userRepository)
        {
            // _tokenService = tokenService;
            _userRepository = userRepository;
        }

        public async Task<Boolean> GetByEmailAsync(string email)
        {
            var existingUser = await _userRepository.GetByEmailAsync(email);

            if(existingUser != null)
            {
                return true;
            }

            return false;
        }

        public async Task<User> CreateUser(User user, string password)
        {
            user.PasswordHash = this.HashPassword(password);

            var createdUser = await _userRepository.CreateAsync(user);

            return createdUser;
            
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
