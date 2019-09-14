using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medfar.Interview.Web.Models
{
    public class User
    {
        public int Guid { get; set; }
        public int first_name { get; set; }
        public int last_name { get; set; }
        public int email { get; set; }
        public DateTime date_created { get; set; }
    }
}