using System;
using System.Net.Mail;
using UmbracoBlue.Core.Controllers;
using UmbracoBlue.Core.ViewModels;
using Umbraco.Core.Logging;

namespace UmbracoBlue.Core.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;

        //dependency injection is baked in in Umbraco 8
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }

        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry form: {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);
                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                //_logger.Error("Error sending contact form", ex);
                _logger.Error(typeof(ContactSurfaceController), ex, "Error sending contact form");
                return false;
            }

        } 
    }
}
