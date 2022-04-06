using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproject1
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public  int Age { get; set; }
        public bool Isactive { get; set; }
        public List<TeacherCourse> TeacherCourses { get; set; }
      
    }
}
