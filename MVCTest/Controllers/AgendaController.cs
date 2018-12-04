using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Random rnd = new Random();
            var newID = rnd.Next();

            Person persona = new Person()
            {
                ID = newID,
                Name = "Daniel Llanos",
                Age = 35
            };

            return View(persona);
        }
    }
}