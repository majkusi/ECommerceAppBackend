using ECommerceAppBackend.DTO;
using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.User;
using ECommerceAppBackend.Services.Register;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ECommerceAppBackend.Controllers;

[ApiController]
[Route("Register/")]
public class RegisterController : Controller
{
   
    private readonly RegisterService _registerService;

    // Constructor
    public RegisterController(RegisterService registerService)
    {
        _registerService = registerService;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterUser(UserRegistrationDto user)
    {
        await _registerService.RegisterUser(user);
        return Ok(user);
    }
}