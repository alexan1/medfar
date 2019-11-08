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

            UserRepository userRep = new UserRepository();
            model.Users = userRep.GetAll();

            //shuffle for fun
            var rnd = new Random();
            model.Users = model.Users.OrderBy(item => rnd.Next()).ToList();

            return View(model);
        }

    }
}