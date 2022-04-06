using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproject1
{
    internal class Controller
    {
        public Controller()
        {

        }
        public  void Create()
        {
            using (var db = new SchoolSystem())
            {
                var Student = new Student
                {
                    Id = 6,
                    Firstname = "Petar",
                    Middlename = "Petkov",
                    Lastname = "Petkov",
                    Birthdate = new DateTime(1997, 2 , 28).ToUniversalTime()
                };
                db.Students.Add(Student);
                db.SaveChanges();
            }
        }
        public  void Read()
        {
            using (var db = new SchoolSystem())
            {
                var AllStudents = db.Students.ToList();
                foreach (var Student in AllStudents)
                {
                    Console.WriteLine($"FirstName:{Student.Firstname}, {Student.Lastname}, {Student.Middlename}, {Student.Lastname}, {Student.Birthdate}");
                }
                Console.Read();
            }
        }
        public  void Update()
        {
            using (var db = new SchoolSystem())
            {
                var Student = db.Students.FirstOrDefault(x => x.Id == 3);
                Student.Firstname = "Elena";
                Student.Middlename = "Petrova";
                db.SaveChanges();
            }
        }
        public void Delete()
        {
            using (var db = new SchoolSystem())
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
        }
        
    }
}
