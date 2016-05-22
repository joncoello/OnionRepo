using OnionRepo.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionRepo.DomainModel.Repositories {
    public interface IContactRepository {
        IEnumerable<Contact> GetContacts();
    }
}
