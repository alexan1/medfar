using Medfar.Interview.DAL.Repositories;
using Medfar.Interview.Types;
using Medfar.Interview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medfar.Interview.Web.Controllers
{
    public class ExampleController : Controller
    {
        public ActionResult Index()
        {
            ExampleViewModel model = new ExampleViewModel();

            User user = new User
            {
                Id = Guid.NewGuid(),
                First_name = "Joe",
                Last_name = "Medfar",
                Email = "joemedfar@medfarsolutions.com",
                Date_created = DateTime.Now
            };
            model.Users.Add(user);

            return View(model);
        }

        public ActionResult LoadData()
        {
            ExampleViewModel model = new ExampleViewModel();

            UserRepository userRep = new UserRepository();
            model.Users = userRep.GetAll();

            //shuffle for fun
            var rnd = new Random();
            model.Users = model.Users.OrderBy(item => rnd.Next()).ToList();

            return View("Index",model);
        }

    }
}