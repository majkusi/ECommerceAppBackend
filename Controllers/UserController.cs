using ECommerceAppBackend.Repositories.User;
using ECommerceAppBackend.Services.JWT;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAppBackend.Controllers
{
[ApiController]
[Route("User/")]
    public class UserController : Controller
    {

    private readonly IUserRepository _userRepository;
    private readonly JwtTokenService _jwtService;
        public UserController(IUserRepository userRepository, JwtTokenService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        [HttpGet("VerifyAccount/")]
        public IActionResult VerifyAccount(string token)
        {
            var user = _jwtService.GetUsernameFromToken(token);
            _userRepository.ConfirmEmail(user);
            return Ok(user);
        }

    }
}
