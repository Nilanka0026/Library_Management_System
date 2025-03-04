using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class lNode
    {
        public Lend Data;
        public lNode? Next;

        public lNode(Lend data)
        {
            Data = data;
            Next = null;
        }
    }
}
