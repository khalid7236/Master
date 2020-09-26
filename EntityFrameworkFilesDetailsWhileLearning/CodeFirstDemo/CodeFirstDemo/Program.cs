using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        public class StudentDetails2
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class BlogDbContext : DbContext
        {
            public DbSet<StudentDetails2> StDetails { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
