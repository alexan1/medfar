using System;
using System.ComponentModel.DataAnnotations;

namespace Medfar.Interview.Types
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string First_name{ get; set; }
        [Required]
        public string Last_name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime Date_created{ get; set; }

    }
}
