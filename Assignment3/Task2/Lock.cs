using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {
        private string lockStatus;

        public string LockStatus { get => lockStatus; set => lockStatus = value; } // Correct lock status are: Open & Close

        public string LockStatus1
        {

            set
            {
                char[] check = value.ToCharArray();
                int c = 0;
                foreach (char v in check)
                {
                    if (char.IsLetterOrDigit(v))
                    {
                        c++;
                    }
                }
                if (c != value.Length)
                {

                    lockStatus = null;
                }
                else
                {
                    lockStatus = value;

                }




            }
            get
            {
                return lockStatus;
            }


        }
    }

}

