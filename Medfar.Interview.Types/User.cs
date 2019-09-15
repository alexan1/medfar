using System;

namespace Medfar.Interview.Types
{
    public class User
    {
        public Guid Id { get; set; }
        public string First_name{ get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public DateTime Date_created{ get; set; }

    }
}
