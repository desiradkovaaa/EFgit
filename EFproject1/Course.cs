using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproject1
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<TeacherCourse> TeacherCourses { get; set; }
   
}
}
