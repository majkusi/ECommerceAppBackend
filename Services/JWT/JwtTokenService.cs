﻿using ECommerceAppBackend.DTO;
using ECommerceAppBackend.Models;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Core.Types;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ECommerceAppBackend.Repositories.User;
using System.Security.Principal;

namespace ECommerceAppBackend.Services.JWT;

public class JwtTokenService
{
    private readonly IConfiguration _config;
    private readonly IUserRepository _repository;

    public JwtTokenService(IConfiguration config, IUserRepository repository)
    {
        _repository = repository;
        _config = config;
    }

    public string GenerateToken(UserModel user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Email),
            new Claim(ClaimTypes.Role, user.UserRole)
        };
        var token = new JwtSecurityToken(_config["Jwt:Issuer"],
            _config["Jwt:Audience"],
            claims,
            expires: DateTime.Now.AddMinutes(15),
            signingCredentials: credentials);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    public UserModel Authenticate(UserLoginDto userModel)
    {   
            var currentUser = _repository.GetUserByEmail(userModel.Email);
            if (currentUser != null) return currentUser;
            return null;    
    }
    public string GetUsernameFromToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"])),
            ValidateIssuer = true,
            ValidIssuer = _config["Jwt:Issuer"],
            ValidateAudience = true,
            ValidAudience = _config["Jwt:Audience"],
            ClockSkew = TimeSpan.Zero
        };
        SecurityToken validatedToken;

        try
        {
            var principal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
            var usernameClaim = principal.FindFirst(ClaimTypes.NameIdentifier);
            var username = usernameClaim?.Value;
            return username;
        }
        catch (Exception e)
        {
            Console.WriteLine("Error while validating token: " + e.Message);
            return null;
        }
    }
}