using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class mNode
    {
        public Member Data;
        public mNode? Next;

        public mNode(Member data)
        {
            Data = data;
            Next = null;
        }
    }
}
