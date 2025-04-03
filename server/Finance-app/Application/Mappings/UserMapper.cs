using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public static class UserMapper
    {
        // Mapeia um RegisterUserRequestDto para uma entidade User
        public static User ToMapperCreateUserRequest(RegisterUserRequestDto registerUserRequestDto)
        {
            return new User
            {
                Name = registerUserRequestDto.Name,
                Email = registerUserRequestDto.Email
            };
        }

        // Mapeia uma entidade User para um DTO de resposta
        public static UserResponseDto toMapperCreateUserResponse(User user)
        {
            return new UserResponseDto
            {
                Name = user.Name,
                Email = user.Email,
                CreatedAt = user.CreatedAt
            };
        }

    }
}
