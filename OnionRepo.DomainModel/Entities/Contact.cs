using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionRepo.DomainModel.Entities {
    
    public class Contact {
        public int ContactID { get; set; }

        [Column("FName")]
        public string FirstName { get; set; }

        [Column("LName")]
        public string LastName { get; set; }
    }
}
