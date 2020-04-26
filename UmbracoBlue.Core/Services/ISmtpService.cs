using System;
using UmbracoBlue.Core.ViewModels;

namespace UmbracoBlue.Core.Services
{
    public interface ISmtpService
    {
        bool SendEmail(ContactViewModel model);
    }
}
