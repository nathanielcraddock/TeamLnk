using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamLnk.Models;

namespace TeamLnk.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<User> users = new List<User>()
            {
                new User { FName = "Vincent", LName = "Saelzler", Email = "v@e.com", Password = "SOEASY" },
                new User { FName = "Nathan", LName = "Craddock", Email = "n@e.com", Password = "SOEASY1" }
            };
            return View(users);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}