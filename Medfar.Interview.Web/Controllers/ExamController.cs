using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medfar.Interview.DAL.Repositories;
using Medfar.Interview.Types;

namespace Medfar.Interview.Web.Controllers
{
    public class ExamController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AddUser(string firstName, string lastName, string email)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            UserRepository userRep = new UserRepository();

            var user = new User()
            {
                Id = Guid.NewGuid(),
                First_name = firstName,
                Last_name = lastName,
                Email = email,
                Date_created = DateTime.Now
            };            

            userRep.Insert(user);
            return View("Example/Index");
            
        }

    }
}