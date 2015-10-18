using System.Data.Entity;
using System.Data.SqlServerCe;
namespace TestConsoleApplication.Data
{
    [DbConfigurationType(typeof(SalesDbConfigurationType))]
    public class SalesContext : DbContext
    {

        public SalesContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public IDbSet<Product> Product { get; set; }
        public IDbSet<Category> Category { get; set; }
        public IDbSet<Supplier> Supplier { get; set; }

    }
}