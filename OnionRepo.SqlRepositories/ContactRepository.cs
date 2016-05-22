using OnionRepo.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionRepo.DomainModel.Entities;

namespace OnionRepo.SqlRepositories
{

    public class ContactRepository : IContactRepository {
        public IEnumerable<Contact> GetContacts() {
            var dbContext = new AppDbContext();
            return dbContext.Contacts.ToList();
        }

    }

}
