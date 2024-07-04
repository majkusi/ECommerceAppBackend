using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Threading.Tasks;
using ECommerceAppBackend.Repositories.User;
using ECommerceAppBackend.Services.JWT;
using ECommerceAppBackend.DTO;

namespace ECommerceAppBackend.Services.EmailSender
{
    public class EmailSender
    {
        private readonly IUserRepository _repository;
        private readonly JwtTokenService _jwtToken;
        private readonly IConfiguration _configuration;
        public EmailSender(IUserRepository repository, JwtTokenService jwtToken, IConfiguration configuration)
        {
            _repository = repository;
            _jwtToken = jwtToken;
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string toEmail, int userId)
        {
            try
            {
                var smtpOptions = _configuration.GetSection("SmtpOptionsPoco").Get<SmtpOptionsPoco>();
                var user = _repository.GetUserById(userId);
                var token = _jwtToken.GenerateToken(user);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ECommerceShop",smtpOptions.UserName));
                message.To.Add(new MailboxAddress(user.Name, toEmail));
                message.Subject = "Aktywacja konta";

                message.Body = new TextPart("plain")
                {
                    Text = "http://localhost:3000/" + token
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    // Retrieve SMTP configuration values from appsettings.json
                    await client.ConnectAsync(smtpOptions.Host, smtpOptions.Port, true);
                    await client.AuthenticateAsync(smtpOptions.UserName, smtpOptions.Password);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send e-mail: {ex.Message}");
                throw;
            }
        }

    }
}
