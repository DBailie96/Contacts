using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Entities;

namespace Repositories
{
    public class ContactRepository : IContactRepository
    {
        protected ApplicationDbContext ApplicationContext { get; set; }
        public ContactRepository(ApplicationDbContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return ApplicationContext.Contacts.ToList();
        }

        public IEnumerable<Contact> SearchContacts(string term)
        {
            return ApplicationContext.Contacts.Where(contact => contact.FirstName.Contains(term) || contact.LastName.Contains(term) || contact.Address.Contains(term)).ToList();
        }

        public Contact GetContactById(int id)
        {
            return ApplicationContext.Contacts.SingleOrDefault(c => c.Id == id);
        }

        public void CreateContact(Contact entity)
        {
            ApplicationContext.Contacts.Add(entity);
            ApplicationContext.SaveChanges();
        }

        public void UpdateContact(Contact entity)
        {
            ApplicationContext.Contacts.Update(entity);
            ApplicationContext.SaveChanges();
        }


        public void DeleteContact(Contact entity)
        {
            ApplicationContext.Contacts.Remove(entity);
            ApplicationContext.SaveChanges();
        }
       




    }
}
