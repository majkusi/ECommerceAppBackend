using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace ECommerceAppBackend.Services.EmailSender
{
    public class EmailSender
    {
        public async Task SendEmailAsync(string toEmail)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("John Doe", "instrumenthero@op.pl"));
                message.To.Add(new MailboxAddress("Bruce Williams", toEmail));
                message.Subject = "Test subject";

                message.Body = new TextPart("plain")
                {
                    Text = "Test body"
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback =
                        (s, c, h, e) => true;
                    await client.ConnectAsync("smtp.poczta.onet.pl", 465, true);
                    await client.AuthenticateAsync("instrumenthero@op.pl", "Haslo123!");
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