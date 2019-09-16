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

        [HttpPost]
        public ActionResult AddUser(User model)
        {

            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            UserRepository userRep = new UserRepository();

            var user = new User()
            {
                Id = Guid.NewGuid(),
                First_name = model.First_name,
                Last_name = model.Last_name,
                Email = model.Email,
                Date_created = DateTime.Now
            };            

            userRep.Insert(user);            
            return RedirectToAction("LoadData", "Example");
            
        }

    }
}