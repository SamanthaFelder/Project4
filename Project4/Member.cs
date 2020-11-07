using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Member
    {
        public List<MemberTypes> MemberType { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int ID { get; set; }
        public DateTime DOB { get; set; }

        public Member()
        {
            MemberType = new List<MemberTypes>();
        }
    }
}
