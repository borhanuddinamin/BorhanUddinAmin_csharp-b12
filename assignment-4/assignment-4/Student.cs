using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    public  class Student:User
    {
        
       // public int StudentId { get; set; }
        //public int UserId { get; set; }
        public Attendance Attendance { get; set; }
        //public Attendance Attendance { get; set; }
       public AssignStudent AssignStudent { get; set; }
      //  public IList<Attendance> Attendance { get; set; }





        public Student(string name, string username, string pass, string Type) : this(username, pass, Type)
        {
            this.Name = name;


        }
        public Student(string username, string pass, string Type) : this()
        {

            this.UserName = username;
            this.Password = pass;
            this.Type = Type;

        }

        public Student()
        {

        }



        public void WelcomeStudent()
        {



        }


    }
}
