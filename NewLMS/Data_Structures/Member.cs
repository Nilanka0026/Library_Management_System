using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class Member
    {
        private static int nextid = 2111;
        public string Name;
        public int Id;
        public string NatID;
        public string City;
        public string Age;
        public string Sex;

        public Member(string name, string id , string city, string age,string sex)
        {
            Name = name;
            NatID = id;
            City = city;
            Age = age;
            Sex = sex;
            Id = nextid;
            nextid++;
        }
    }
}
