using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        const string error1 = "Username must be provided";
        const string error2 = "Email must be provided";
        const string error3 = "Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return error1 ;
            if (string.IsNullOrWhiteSpace(email))
                return error2;
            if (string.IsNullOrWhiteSpace(password))
                return error3;

            return string.Empty;
        }
    }
}
