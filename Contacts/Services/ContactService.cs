using DTOs;
using System.Text.Json;

namespace Contacts.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ContactService(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<List<ContactDTO>> GetContacts()
        {

            var res = await _client.GetAsync("contacts");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }


            var contacts = JsonSerializer.Deserialize<List<ContactDTO>>(content, _options);
            return contacts;
        }

        public async Task<List<ContactDTO>> SearchContacts(string searchterm)
        {
            //this needs to attatch searchterm somehow
            var res = await _client.GetAsync($"contacts/search/{searchterm}");

            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }


            var contacts = JsonSerializer.Deserialize<List<ContactDTO>>(content, _options);
            return contacts;
        }

        public async Task<ContactDTO> GetContact(int? id)
        {
            var res = await _client.GetAsync($"contacts/{id}");
            var content = await res.Content.ReadAsStringAsync();

            if (!res.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var contact = JsonSerializer.Deserialize<ContactDTO>(content, _options);
            return contact;
        }

        public async Task AddContact(ContactDTO contact)
        {
            await _client.PostAsJsonAsync<ContactDTO>("contacts", contact);
        }

        public async Task DeleteContact(int id)
        {
            await _client.DeleteAsync($"contacts/{id}");
        }

        public async Task UpdateContact(ContactDTO contact)
        {
            await _client.PutAsJsonAsync<ContactDTO>($"contacts/{contact.Id}", contact);
        }
    }
}
