using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    internal class Program
    {
        public enum Level: byte
        {
            Nuevo = 1,
            Intermedio = 2,
            Adelantado= 3
        }
        static void Main(string[] args)
        {

            var dbContext = new PlutoDbContext();

            dbContext.GetAuthorCourses(1);

            var courses = dbContext.GetCourses();

            foreach (var item in courses)
            {
                Console.WriteLine(  item.Title);
            }

            var course = new Courses();
            course.Level = CourseLevel.Begginer;
        }
    }
}
