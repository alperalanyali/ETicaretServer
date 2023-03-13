using System;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;


namespace Infrastructure.Services
{
	public static class EmailSenderService
	{
        public static async Task<bool> SendEmail(string subject,string htmlContent,List<EmailAddress> tos)
        {
            var apiKey = "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"; //Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("alper_alanyali@hotmail.com", "E-Ticaret  Alper");
            //var subject = "Sending with SendGrid is Fun";
            //var to = new EmailAddress("test@example.com", "Example User");
            //var plainTextContent = "and easy to do anywhere, even with C#";
            //var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject,"" ,htmlContent);
            var response = await client.SendEmailAsync(msg);

            var result = response.IsSuccessStatusCode;

            return result;
        }
    }
}

