
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Mvc;
using Domain.Dtos.Request;
using Application.Services;
using Application.Mappings;

namespace Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;
    private readonly IUserRepository _userRepository;
    private readonly UserService _userService;

    //public AuthController(TokenService tokenService, IUserRepository userRepository)
    //{
    //    _tokenService = tokenService;
    //    _userRepository = userRepository;
    //}

    public AuthController(UserService userService)
    {
        _userService = userService;
    }

    //[HttpPost("login")]
    //public async Task<IActionResult> Login(string email, string password)
    //{
    //    var user = await _userRepository.GetByEmailAsync(email);
    //    if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
    //        return Unauthorized();

    //    var token = _tokenService.GenerateToken(user);
    //    return Ok(new { Token = token });
    //}

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto registerUserRequestDto)
    {
        try
        {
            var existingUser = await _userService.GetByEmailAsync(registerUserRequestDto.Email);

            if (existingUser)
            {
                throw new Exception();
            }

            var user = UserMapper.ToMapperCreateUserRequest(registerUserRequestDto);

            var createdUser = await _userService.CreateUser(user, registerUserRequestDto.Password);

            var response = UserMapper.toMapperCreateUserResponse(createdUser);

            return Ok(response);

        } 
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        } 
    }

}