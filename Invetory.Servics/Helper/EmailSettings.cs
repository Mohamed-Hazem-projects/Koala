using System.Net.Mail;
using System.Net;

namespace Invetory.Servics.Helper
{
    public class EmailSettings
    {
        public static void SendEmail(Email input)
        {
            try
            {
                var client = new SmtpClient("smtp.mail.yahoo.com", 465); 
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("arsanynashat@yahoo.com", "cmmlizrxbjlmvmyh");
                client.DeliveryMethod = SmtpDeliveryMethod.Network; 

                MailMessage mailMessage = new MailMessage("arsanynashat@yahoo.com", input.To, input.subject, input.body);
                mailMessage.IsBodyHtml = true;

                client.Send(mailMessage);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }
}
