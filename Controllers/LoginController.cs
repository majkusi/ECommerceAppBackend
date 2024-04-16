using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ECommerceAppBackend.DTO;
using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace ECommerceAppBackend.Controllers;

public class LoginController : Controller
{
    private readonly IConfiguration _config;
    private readonly IUserRepository _repository;

    public LoginController(IConfiguration config, IUserRepository repository)
    {
        _repository = repository;
        _config = config;
    }

    [AllowAnonymous]
    [HttpPost]
    public ActionResult Login([FromBody] UserLoginDto userLoginDto)
    {
        var user = Authenticate(userLoginDto);
        if (user != null)
        {
            var token = GenerateToken(user);
            return Ok(token);
        }

        return NotFound("user not found");
    }

    // To generate token
    private string GenerateToken(UserModel user)
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

    //To authenticate user
    private UserModel Authenticate(UserLoginDto userModel)
    {
        var currentUser = _repository.GetAllUsers().FirstOrDefault(x => x.Email.ToLower() ==
            userModel.Username.ToLower() && x.Password == userModel.Password);
        if (currentUser != null) return currentUser;

        return null;
    }
}