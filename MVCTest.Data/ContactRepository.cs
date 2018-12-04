using MVCTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.Data
{
    public class ContactRepository
    {
        public static List<Contact> Data = new List<Contact>()
        {
            new Contact(){ ID=1, Name="Daniel Llanos", Email="dllanosm@hotmail.com"},
            new Contact(){ ID=2, Name="Persona 1", Email="pone@hotmail.com"},
            new Contact(){ ID=3, Name="Persona 2", Email="ptwo@hotmail.com"},
            new Contact(){ ID=4, Name="Persona 3", Email="pthree@hotmail.com"},
            new Contact(){ ID=5, Name="Persona 4", Email="pfour@hotmail.com"}
        };

        public Contact getContact(int id)
        {
            return Data.FirstOrDefault(i => i.ID == id);
        }
    
        public List<Contact> getAllContacts()
        {
            return Data;
        }

        public void AddContact(Contact objContact)
        {
            objContact.ID = Data.Count() + 1;
            Data.Add(objContact);
        }
    }
}
