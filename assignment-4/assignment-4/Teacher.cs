using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    public  class Teacher:User
    {
       //public int TeacherId { get; set; }
       
      //  public IList<AssignTeacher> AssignTeacher { get; set; }




        public Teacher(string name, string userName, string password, string Type) : this(userName, password, Type)
        {
            this.Name = name;
        
        }
        public Teacher(string userName, string password, string Type) : this()
        {

            this.UserName = userName;
            this.Password = password;
            this.Type = Type;
        }
        public Teacher()
        {


        }


        public void WelcomeTeacher()
        {



        }
    }
}
