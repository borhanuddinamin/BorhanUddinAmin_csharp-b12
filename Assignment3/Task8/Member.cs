using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Member
    {
        internal string membershipId;
        internal string Name { get; set; }
        protected internal DateTime MembershipExpirationDate { get; set; }

        public Member()
        {
            membershipId = Guid.NewGuid().ToString();
        }
    }
}
