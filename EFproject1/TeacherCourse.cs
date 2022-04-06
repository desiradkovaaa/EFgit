using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFproject1
{
    public class TeacherCourse
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int TeacherCourse_pk { get; set; }
		public Course Course { get; set; }
		public  Teacher Teacher { get; set; }
		
	}
}

