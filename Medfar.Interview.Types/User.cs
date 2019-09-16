using System;
using System.ComponentModel.DataAnnotations;

namespace Medfar.Interview.Types
{
    public class User
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter the user's first name.")]
        [Display(Name = "First Name")]
        public string First_name{ get; set; }
        [Required(ErrorMessage = "Please enter the user's last name.")]
        [Display(Name = "Last Name")]
        public string Last_name { get; set; }
        [EmailAddress(ErrorMessage = "The Email Address is not valid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = false)]
        public DateTime Date_created{ get; set; }

    }
}
