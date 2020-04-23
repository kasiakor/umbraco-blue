using ClientDependency.Core.Logging;
using System;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoBlue.Core.ViewModels;

namespace UmbracoBlue.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ILogger _logger;

        //dependency injection is baked in in Umbraco 8
        public ContactSurfaceController(ILogger logger)
        {
            _logger = logger;      
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel() { ContactFormId = CurrentPage.Id };

            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
         
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);

        }

        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;

            if (ModelState.IsValid)
            {
            //we pass the model in from the SendMail method below
                success = SendMail(model);

            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);
            var successMessage = contactPage.Value<IHtmlString>("successMessage");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessage");
            return PartialView("~/Views/Partials/Contact/result.cshtml", success ? successMessage : errorMessage);
        }
        public bool SendMail(ContactViewModel model)
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
                _logger.Error("Error sending contact form", ex);
                return false;
            }
        }
    }
}
