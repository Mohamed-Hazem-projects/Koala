using System.Net.Mail;
using System.Net;

namespace KoalaInventoryManagement.ViewModels.Authentication
{
    public class EmailSettings
    {
        public static async Task SendEmailAsync(Email input)
        {
            try
            {
                var client = new SmtpClient("smtp.mail.yahoo.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("arsanynashaat@yahoo.com", "cmmlizrxbjlmvmyh"); // Use app password for security
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                var mailMessage = new MailMessage("arsanynashaat@yahoo.com", input.To, input.subject, input.body)
                {
                    IsBodyHtml = true // Since you are sending HTML content
                };

                await client.SendMailAsync(mailMessage); // Await the send operation
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }
}
