using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CollectionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrStr = new string[10];
            arrStr[0] = "aaa";
            arrStr[1] = "abc";
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.Log = Console.WriteLine;





            QueryIQuereable(context);
           // QueryIEnumerable(context);
           


          
            

            Console.ReadKey();
        }

        static void QueryIQuereable(ApplicationDbContext context)
        {
            //Quereable query on sql server return result
            IQueryable<Customer> customers = context.Customers.Where(x => x.Id > 10 && x.Id < 15);
            var customer = customers.Where(x => x.Id > 10 && x.Id < 15);
            customers = customers.Where(x => x.Id < 14);
            //chua execute db

            customer.ToList();
            Console.WriteLine(customers.Count());
        }

        static void QueryIEnumerable(ApplicationDbContext context) 
        {
            List<Customer> l = new List<Customer>();
            Dictionary<string, Customer> d = new Dictionary<string, Customer>();
            //IEnumerable query on memory
            IEnumerable<Customer> result = context.Customers;

            var customers = result.Where(x => x.Id > 10 && x.Id < 15);
            customers = customers.Where(x=> x.Id < 14);
            //chua execute db
            //customers.ToList();
            //
            //var result2 = context.Customers.ToList();
            // customers = result2.Where(x => x.Id > 10 && x.Id < 15);

            //IEnumerable<Customer> queryIEnumerable = from c in context.Customers select c;
            // var customers = queryIEnumerable.Where(x => x.Id > 10 && x.Id < 15).ToList();
            Console.WriteLine(customers.Count());
        }
    }

   }
