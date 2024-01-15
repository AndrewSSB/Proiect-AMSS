using BookHub.BLL.Interfaces;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Threading.Tasks;
using BookHub.BLL.DTOs;

namespace BookHub.BLL.Managers
{
    public class UserManager : IUserManager
    {
        public virtual async Task SendEmailTemplate(EmailReceiverDTO emailDto)
        {
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");

            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(Environment.GetEnvironmentVariable("SENDGRID_EMAIL"), Environment.GetEnvironmentVariable("SENDGRID_NAME"));
            var to = new EmailAddress(emailDto.Email, emailDto.Name);
            var subject = "Thank you for your register!";
            var plainTextContent = "Hi!";
            var htmlContent = "<p><span style=\"font-family:Lucida Sans Unicode,Lucida Grande,sans-serif\"><span style=\"font-size:16px\">Hello, thank you for registering on Bookgram!&nbsp;</span></p>" +
                "<p><span style=\"font-family:Lucida Sans Unicode,Lucida Grande,sans-serif\">BookGram is the right place for your reading! You will be able to post your favorite books, you will have weekly challenges and you will be able to make friends who love reading.</span></p>" +
                "<p>&nbsp;</p>";
            var msg = MailHelper.CreateSingleEmail(
                from,
                to,
                subject,
                plainTextContent,
                htmlContent
           );
           await client.SendEmailAsync(msg);
        }
    }
}
