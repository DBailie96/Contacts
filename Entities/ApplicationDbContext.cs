using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Contact>()
                .HasData(
            new Contact
            {
                Id = 1,
                FirstName = "Daniel",
                LastName = "Bailie",
                DateOfBirth = new DateTime(1996, 07, 22),
                PhoneNumber = "0799693943",
                Address = "Amanzimtoti, Durban"
            },
            new Contact
            {
                Id = 2,
                FirstName = "Armand",
                LastName = "Van Den Berg",
                DateOfBirth = new DateTime(1999, 01, 13),
                PhoneNumber = "0822273436",
                Address = "Bloemfontein"
            },
            new Contact
            {
                Id = 3,
                FirstName = "Andrew",
                LastName = "Trautmann",
                DateOfBirth = new DateTime(1998, 08, 12),
                PhoneNumber = "0742418384",
                Address = "Western Cape"
            },
            new Contact
            {
                Id = 4,
                FirstName = "Ashton",
                LastName = "Naidoo",
                DateOfBirth = new DateTime(1991, 10, 18),
                PhoneNumber = "079963765",
                Address = "Pinetown, Durban"
            },
            new Contact
            {
                Id = 5,
                FirstName = "Iviwe",
                LastName = "Malotana",
                DateOfBirth = new DateTime(1998, 10, 03),
                PhoneNumber = "0848688642",
                Address = "Western Cape"
            },
            new Contact
            {
                Id = 6,
                FirstName = "Miguel",
                LastName = "Serrao",
                DateOfBirth = new DateTime(1997, 07, 12),
                PhoneNumber = "0726247199",
                Address = "Baloni, Gauteng"
            },
            new Contact
            {
                Id = 7,
                FirstName = "Brendon",
                LastName = "Du Plessis",
                DateOfBirth = new DateTime(1996, 08, 08),
                PhoneNumber = "079964343",
                Address = "Amanzimtoti, Durban"
            },
            new Contact
            {
                Id = 8,
                FirstName = "Shaun",
                LastName = "Mhlanga",
                DateOfBirth = new DateTime(1996, 04, 04),
                PhoneNumber = "0736908846",
                Address = "Kloof, Durban"
            },
            new Contact
            {
                Id = 9,
                FirstName = "Skye",
                LastName = "Mclennan",
                DateOfBirth = new DateTime(1995, 11, 25),
                PhoneNumber = "0791658222",
                Address = "Benoni, Gauteng"
            },
            new Contact
            {
                Id = 10,
                FirstName = "Nathan",
                LastName = "Geel",
                DateOfBirth = new DateTime(1994, 07, 22),
                PhoneNumber = "0744900337",
                Address = "Waterfall, Durban"
            },
            new Contact
            {
                Id = 11,
                FirstName = "Justin",
                LastName = "Pillay",
                DateOfBirth = new DateTime(1994, 04, 14),
                PhoneNumber = "0761372711",
                Address = "Westville, Durban"
            },
            new Contact
            {
                Id = 12,
                FirstName = "Tannah",
                LastName = "Renou",
                DateOfBirth = new DateTime(1998, 07, 28),
                PhoneNumber = "0810292529",
                Address = "Queensburgh, Durban"
            },
            new Contact
            {
                Id = 13,
                FirstName = "Luke",
                LastName = "Venter",
                DateOfBirth = new DateTime(1998, 04, 26),
                PhoneNumber = "0715155922",
                Address = "Pietermaritzburg, Durban"
            },
            new Contact
            {
                Id = 14,
                FirstName = "Jason",
                LastName = "Smit",
                DateOfBirth = new DateTime(1993, 11, 25),
                PhoneNumber = "0745146774",
                Address = "Western Cape"
            },
            new Contact
            {
                Id = 15,
                FirstName = "Terence",
                LastName = "Frade",
                DateOfBirth = new DateTime(1996, 08, 12),
                PhoneNumber = "0760317085",
                Address = "Pretoria"
            }
            );
        }
    }
}
