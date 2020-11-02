using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Member
    {
        public Member()
        {

        }

        public Member(string name, int type, int id, DateTime dob)
        {
            Name = name;
            Type = type;
            ID = id;
            DOB = dob;
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public int ID { get; set; }
        public DateTime DOB { get; set; }
    }
}
