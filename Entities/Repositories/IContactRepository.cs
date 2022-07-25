using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;

namespace Repositories
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();

        IEnumerable<Contact> SearchContacts(string term);
        Contact GetContactById(int id);
        void CreateContact(Contact entity);
        void UpdateContact(Contact entity);
        void DeleteContact(Contact entity);
    }
}
