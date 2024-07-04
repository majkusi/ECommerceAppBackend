using System.IdentityModel.Tokens.Jwt;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using ECommerceAppBackend.DTO;
using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.User;
using ECommerceAppBackend.Services.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace ECommerceAppBackend.Controllers;
[ApiController]
[Route ("Login/")]
public class LoginController : Controller
{
    private readonly JwtTokenService _jwtService;
    public LoginController(JwtTokenService jwtService)
    {
        _jwtService = jwtService;
    }

    [AllowAnonymous]
    [HttpPost]
    public ActionResult Login([FromBody] UserLoginDto userLoginDto)
    {     
        var user = _jwtService.Authenticate(userLoginDto);
        var token = _jwtService.GenerateToken(user);
        return Ok(token);
    }

}