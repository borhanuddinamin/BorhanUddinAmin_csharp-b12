using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    public  class Attendance
    {
      
        public int AttendanceId { get; set; }

        public Student Student { get; set; }

      
        public int StudentId { get; set; }
        public Course Course { get; set; }

       
        public int CourseId { get; set; }
        //public ClassSchedule ClassSchedule { get; set; }

        public DateTime StartTime { get; set; }


        public bool Ispresent { get; set; }
    }
}
