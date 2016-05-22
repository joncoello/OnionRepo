using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace OnionRepo.SqlRepositories {
    internal class MyDbConfiguration : DbConfiguration {
        public MyDbConfiguration() {
            this.SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy());
            this.SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
            this.SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);
        }
    }
}