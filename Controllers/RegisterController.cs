using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.User;
using ECommerceAppBackend.Services.Register;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace ECommerceAppBackend.Controllers;
[ApiController]
[Route("Register/")]
public class RegisterController :Controller
{
    private readonly IUserRepository _userRepository;
    private readonly RegisterService _registerService;

    // Constructor
    public RegisterController(IUserRepository userRepository, RegisterService registerService) 
    {
        _userRepository = userRepository;
        _registerService = registerService;
    }
    
    [HttpPost]
    public IActionResult RegisterUser(UserModel user)
    {
        _registerService.RegisterUser(user);
        return Ok(user);
    }


}