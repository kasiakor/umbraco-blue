using Umbraco.Core;
using Umbraco.Core.Composing;
using UmbracoBlue.Core.Services;

namespace UmbracoBlue.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            //Lifetime - how long we want the service to last
            //we want to register ISmtp Service on this composition and we  want it to be created as SmtpService class
            composition.Register < ISmtpService, SmtpService > (Lifetime.Singleton);
        }

    }
}
