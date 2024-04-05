using ECommerceAppBackend.Models;
using ECommerceAppBackend.Repositories.User;

namespace ECommerceAppBackend.Services.Register
{
    public class RegisterService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordService _passwordService;
        private readonly EmailSender.EmailSender _emailSender;

        public RegisterService(IUserRepository userRepository, PasswordService passwordService,
            EmailSender.EmailSender emailSender)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
            _emailSender = emailSender;
        }

        public async Task RegisterUser(UserModel user)
        {
            var hashedPassword = PasswordCheckHash(user.Password);
            if (hashedPassword == string.Empty || !IsValidEmail(user.Email))
            {
                Console.WriteLine("Error");
            }

            await _emailSender.SendEmailAsync(user.Email);
            user.Password = hashedPassword;
            _userRepository.CreateNewUser(user);
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

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}