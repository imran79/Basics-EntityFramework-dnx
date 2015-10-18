
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlServerCe;

namespace TestConsoleApplication.Data
{
   public class SalesDbConfigurationType : DbConfiguration	
   {
	   public SalesDbConfigurationType()
        {
           
            this.SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory
                ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));



                
           // this.SetProviderFactory("System.Data.SqlServerCe.4.0", new System.Data.SqlServerCe.SqlCeProviderFactory());

        }
   }
}