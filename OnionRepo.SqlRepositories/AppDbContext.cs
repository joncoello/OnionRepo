using OnionRepo.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionRepo.SqlRepositories {

    [DbConfigurationType(typeof(MyDbConfiguration))]
    class AppDbContext : DbContext {

        public AppDbContext() : base(@"server = WLK5CB31214W6\CCH2008 ; database = central ; user id = vpmuser ; PWD = BelfrY18") {

            // turn off schema modification
            Database.SetInitializer<AppDbContext>(null);

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
