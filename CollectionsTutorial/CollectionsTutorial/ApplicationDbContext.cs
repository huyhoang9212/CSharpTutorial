using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
namespace CollectionsTutorial
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            :base("name=DatabaseContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
