using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoBlue.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Enter your name" )]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email address")]
        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public string EmailAdrress { get; set; }

        [Required(ErrorMessage = "Enter your message")]
        [MaxLength(500, ErrorMessage = "Your message must be no longer than 500 characters")]
        public string Message { get; set; }
    }
}
