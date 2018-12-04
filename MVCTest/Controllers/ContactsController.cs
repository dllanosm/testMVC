using MVCTest.Logic;
using MVCTest.ViewHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class ContactsController : Controller
    {
        private ContactLogic _contactLogic;

        public ContactsController()
        {
            _contactLogic = new ContactLogic();
        }

        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddContactViewHandler objContact)
        {
            var newContact = ContactTranslator.GetContactModel(objContact);
            _contactLogic.AddContact(newContact);
            return RedirectToAction("Details", new { id = newContact.ID });
        }

        public ActionResult Details(int Id)
        {
            var ContactRecord = _contactLogic.getContact(Id);
            var contactVHandler = ContactTranslator.GetContactView(ContactRecord);

            return View(contactVHandler);
        }
    }
}