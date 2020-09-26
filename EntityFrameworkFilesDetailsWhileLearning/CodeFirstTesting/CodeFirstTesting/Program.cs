using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTesting
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class BlogDbContext : DbContext
    {
        public DbSet<StudentDetails2> studentDetails { get; set; }
    }
    public class StudentDetails2
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
