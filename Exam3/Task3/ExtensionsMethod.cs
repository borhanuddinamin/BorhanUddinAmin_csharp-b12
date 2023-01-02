using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public  class ExtensionsMethod
    {

        public static int sum( Stack<int> stack)
        {
            int tottal = 0;
            foreach (int s in stack)
            {
                tottal = tottal + s;
            }
            return tottal;
        }



    }
}
