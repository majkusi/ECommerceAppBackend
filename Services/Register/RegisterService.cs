using ECommerceAppBackend.DTO;
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
        public async Task RegisterUser(UserRegistrationDto user)
        {

            var userModel = MapUserRegistrationDtoToUserModel(user);

            var hashedPassword = PasswordCheckHash(user.Password);
            if (hashedPassword == string.Empty || !IsValidEmail(user.Email))
            {
                Console.WriteLine("Error");
            }
            userModel.Password = hashedPassword;
            _userRepository.CreateNewUser(userModel);
            await _emailSender.SendEmailAsync(user.Email, userModel.Id);
        }

        private UserModel MapUserRegistrationDtoToUserModel(UserRegistrationDto user)
        {
            return new UserModel
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
        }
        private string PasswordCheckHash(string password)
        {
            if (!(password.Length > 8 && password.Any(c => !char.IsLetterOrDigit(c))))
                throw new FormatException("Invalid password format");
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
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}