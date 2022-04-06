using System;
using System.Linq;
namespace EFproject1
{
    public class Program
    {

        static void Main(string[] args)
        {
            ///Create Function
            /* using (var db = new SchoolSystem())
             {
                 var Student = new Student
                 {
                     Id = 4,
                     Firstname = "Desislava",
                     Middlename = "Ivanova",
                     Lastname = "Radkova",
                     Birthdate= new DateTime(1999,3,29).ToUniversalTime()
                 };
                 db.Students.Add(Student);
                 db.SaveChanges();
             }
            */
            ///Udate Function
            /* using (var db= new SchoolSystem())
             {
                 var Student = db.Students.FirstOrDefault(x => x.Id == 3);
                 Student.Firstname = "Elena";
                 Student.Middlename = "Petrova";
                 db.SaveChanges();
             }
            */
            ///Delete Function
            /* using (var db= new SchoolSystem())
             {
                 var Student = new Student()
                 {
                     Id = 5,
                     Firstname = "Kristiyan",
                     Middlename = "Ivanov",
                     Lastname = "Hristov",
                     Birthdate = new DateTime(2000, 2, 14).ToUniversalTime()
                 };

                db.Students.Remove(Student);
                 db.SaveChanges();

             }
            */
            //Read Function
            /*
            using (var db = new SchoolSystem())
            {
                var AllStudents = db.Students.ToList();
                foreach(var Student in AllStudents)
                {
                    Console.WriteLine($"FirstName:{Student.Firstname}, {Student.Lastname}, {Student.Middlename}, {Student.Lastname}, {Student.Birthdate}");
                }
                Console.Read();
            }

        }
            */
            Controller c = new Controller();
            c.Create();
            
        }
    }
}
