using Contacts.Services;
using DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Contacts.Pages
{
    public partial class MyContacts
    {
        public List<ContactDTO> ContactList { get; set; } = new List<ContactDTO>();

        public bool optionsIsOpen = false;

        public bool pageLoading = true;

        public string searchTerm = "";

        public ContactDTO SelectedContact { get; set; } = new ContactDTO();

        [Inject]
        public IContactService ContactService { get; set; }

        public bool isDeleting = false;

        protected async override Task OnInitializedAsync()
        {
            ContactList = await ContactService.GetContacts();


            pageLoading = false;
        }


        public void ContactOptions(ContactDTO contact)
        {
            optionsIsOpen = true;
            SelectedContact = contact;
        }


        public async Task DeleteContact(int id)
        {
            isDeleting = true;

            await ContactService.DeleteContact(id);

            await JSRuntime.InvokeVoidAsync("alert", "Contact deleted successfully.");

            ContactList = await ContactService.GetContacts();

            isDeleting = false;
            optionsIsOpen = false;
        }

        public void EditContact(int id)
        {
            nav.NavigateTo($"/addcontact/{id}");
        }

        public void NavToAddContact()
        {
            nav.NavigateTo("/addcontact");
        }

        public async Task SearchContacts(string searchterm)
        {
            if(searchterm=="")
            {
                ContactList = await ContactService.GetContacts();
            }
            else
            {
                ContactList = await ContactService.SearchContacts(searchterm);
            }
        }
    }
}
