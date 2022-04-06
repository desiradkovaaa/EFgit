using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Status { current, finished, canceled };
namespace EFproject1
{
    public class StudentCourse
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Status StatusCourse { get; set; }
        public double Grade { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; } 
       
    }
}
