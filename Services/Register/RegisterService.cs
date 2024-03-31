using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.User;

namespace ECommerceAppBackend.Services.Register
{
    public class RegisterService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordService _passwordService;

        public RegisterService(IUserRepository userRepository, PasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public string RegisterUser(UserModel user)
        {
            var hashedPassword = PasswordCheckHash(user.Password);

            if (hashedPassword == string.Empty || !IsValidEmail(user.Email))
            {
                return "Invalid credentials";
            }
            user.Password = hashedPassword;
            _userRepository.CreateNewUser(user);
            return "Registered, verification email send";
        }

        private string PasswordCheckHash(string password)
        {
            if (!(password.Length > 8 && password.Any(c => !char.IsLetterOrDigit(c))))
                return string.Empty;
            var hashedPassword = _passwordService.HashPassword(password);
            return hashedPassword;
        }
        
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith(".")) {
                return false; 
            }
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch {
                return false;
            }
        }
    }
}