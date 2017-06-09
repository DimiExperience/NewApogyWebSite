using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewApogyWebSite.Models
{
    public class EmailFormModel
    {
        public string Products { get; set; }

        [Display(Name = "Company")]
        public string Company { get; set; }
        [Required, Display(Name = "Your Name *")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your Email *"), EmailAddress]
        public string FromEmail { get; set; }
        [Required, Display(Name = "Your Message *")]
        public string Message { get; set; }
    }
}