using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataBaseFirstDemoEntities();
            var student = new StudentDetail
            {
                ID = 1,
                Name = "Khalid",
                Age=25
            };
            data.StudentDetails.Add(student);
            data.SaveChanges();
        }
    }
}
