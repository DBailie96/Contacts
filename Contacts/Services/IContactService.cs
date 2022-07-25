using Contacts.Paging;
using DTOs;

namespace Contacts.Services
{
    public interface IContactService
    {
        Task<List<ContactDTO>> GetContacts();

        Task<List<ContactDTO>> SearchContacts(string searchterm);

        Task<ContactDTO> GetContact(int? id);

        Task AddContact(ContactDTO contact);

        Task DeleteContact(int id);

        Task UpdateContact(ContactDTO contact);
    }
}
