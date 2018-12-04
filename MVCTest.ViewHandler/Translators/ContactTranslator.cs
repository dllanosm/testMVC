using MVCTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.ViewHandler
{
    public static class ContactTranslator
    {
        public static ContactViewHandler GetContactView(Contact contactFrom)
        {
            ContactViewHandler contact = new ContactViewHandler()
            {
                ID = contactFrom.ID,
                Name = contactFrom.Name,
                Email = contactFrom.Email
            };

            return contact;
        }

        public static Contact GetContactModel(AddContactViewHandler contactFrom)
        {
            Contact _contact = new Contact()
            {
                //ID = contactFrom.ID,
                Name = contactFrom.FullName,
                Email = contactFrom.EmailAddress
            };

            return _contact;
        }
    }
}
