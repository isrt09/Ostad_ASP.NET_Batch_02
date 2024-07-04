using Inventory.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var account = new Account()
            {
                Name    = "Mazedur",
                Email   = "mazedur@gmail.com",
                Address = "Banani, Dhaka 1205"
            };
            
            return View(account);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register Here.";

            return View();
        }

        public ActionResult Dashboard() 
        {
            var equipments = new List<Equipment>
        {
            new Equipment { Id = 1, Name = "Laptop",    Description = "Dell Laptop",   IsAssigned = true, MemberId = 1 },
            new Equipment { Id = 2, Name = "Projector", Description = "HD Projector",  IsAssigned = false },
            new Equipment { Id = 3, Name = "Phone",     Description = "iPhone",        IsAssigned = true, MemberId = 2 },
            new Equipment { Id = 4, Name = "Desktop PC",Description = "Dell PC",       IsAssigned = true, MemberId = 3 },
            new Equipment { Id = 5, Name = "Printer",   Description = "Laser Printer", IsAssigned = true, MemberId = 4 }
        };

            var members = new List<Member>
        {
            new Member { MemberId = 1, Name = "James Smith", Email = "james@gmail.com" },            
            new Member { MemberId = 2, Name = "John Doe",    Email = "john@hotmail.com" },
            new Member { MemberId = 3, Name = "John Welson", Email = "welson@yahoo.cn" },
            new Member { MemberId = 4, Name = "John Henry",  Email = "henry@yahoo.co.uk" }
        };


            var viewModel = new DashboardViewModel
            {
                Equipments = equipments,
                Members    = members
            };
            return View(viewModel);
        }

    }
}
