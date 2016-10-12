namespace CollectionsTutorial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SqlClient;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CollectionsTutorial.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CollectionsTutorial.ApplicationDbContext context)
        {
            string @table = "Customers";
            context.Database.ExecuteSqlCommand("Delete from Customers where 1 = @p0", 1);
            for (int i = 1; i < 10; i++)
            {
                context.Customers.Add(new Customer { Id = i, Name = "Hoang" + i, Age = 25 });
            }
            context.SaveChanges();
        }
    }
}
