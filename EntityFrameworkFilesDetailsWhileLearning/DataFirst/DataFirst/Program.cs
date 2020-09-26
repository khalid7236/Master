using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFirst
{
    class Program
    {
        public enum Level : Byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advance = 3
        }

        static void Main(string[] args)
        {
            var pluto = new PlutoEntities();
            var courses = pluto.GetCourses();
            foreach (var c in courses)
                Console.WriteLine(c.Title);
            Console.ReadLine();
        }
    }
}
