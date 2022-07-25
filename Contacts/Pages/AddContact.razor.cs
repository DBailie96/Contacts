using Contacts.Services;
using DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Contacts.Pages
{
    public partial class AddContact
    {
        [Inject]
        public IContactService ContactService { get; set; }

        [Parameter]
        public int? contactid { get; set; }

        public ContactDTO newContact = new();

        public bool isEditForm = false;


        protected override async Task OnInitializedAsync()
        {
            if (contactid is not null)
            {
                isEditForm = true;
                newContact = await ContactService.GetContact(contactid);
            }
            else
            {
                newContact = new();
            }
        }


        public async void CreateContact(ContactDTO contact)
        {
            if(isEditForm)
            {
                await ContactService.UpdateContact(contact);

                await JSRuntime.InvokeVoidAsync("alert", "Contact updated successfully");
            }
            else
            {
                await ContactService.AddContact(contact);

                await JSRuntime.InvokeVoidAsync("alert", "Contact created successfully");
            }

            nav.NavigateTo("/mycontacts");
        }

        public async void UpdateContact(ContactDTO contact)
        {
            await ContactService.UpdateContact(contact);
        }
    }
}
