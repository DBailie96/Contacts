using AutoMapper;
using ContactsAPI.DTOs;
using Entities.Models;

namespace ContactsAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactDTO>();
        }
    }
}
