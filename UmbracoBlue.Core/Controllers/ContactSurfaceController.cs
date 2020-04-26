using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoBlue.Core.Services;
using UmbracoBlue.Core.ViewModels;


namespace UmbracoBlue.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        //we use it instead of ILogger

        private readonly ISmtpService _smtpService;

        //dependency injection is baked in in Umbraco 8
        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
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
            //now it will be using a service when passing the model to send email
                success = _smtpService.SendEmail(model);

            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);
            var successMessage = contactPage.Value<IHtmlString>("successMessage");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessage");
            return PartialView("~/Views/Partials/Contact/result.cshtml", success ? successMessage : errorMessage);
        }
    }
}
