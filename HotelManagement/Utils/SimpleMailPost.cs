using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Utils
{
    internal class SimpleMailPost
    {

        private static string _email = "infinitehotelco@gmail.com";
        private static string _password = "cxwnohsnjarwltpg";
        private static string _mailServer = "smtp.gmail.com";
        public static bool SendMail(string receiverEmail, string subject, string body, string atthachedPath)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(_email);
            message.To.Add(new MailAddress(receiverEmail));
            message.Subject = subject;
            message.Body = body;
            try
            {

                Attachment attachment = new Attachment(atthachedPath);
                message.Attachments.Add(attachment);
                SmtpClient client = new SmtpClient(_mailServer);//letohetinifni
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(_email, _password);//cxwnohsnjarwltpg
                client.EnableSsl = true;
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
            
    }
}
