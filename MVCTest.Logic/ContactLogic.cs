using MVCTest.Data;
using MVCTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.Logic
{
    public class ContactLogic
    {
        private ContactRepository _contactRepo;

        public ContactLogic()
        {
            _contactRepo = new ContactRepository();
        }

        public Contact getContact(int contactID)
        {
            return _contactRepo.getContact(contactID);
        }

        public List<Contact> getAllContacts()
        {
            return _contactRepo.getAllContacts();
        }

        public void AddContact(Contact objContact)
        {
            _contactRepo.AddContact(objContact);
        }
    }
}
