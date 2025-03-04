using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace NewLMS.Data_Structures
{
    public class Node
    {
        public Book Data;
        public Node? Next;

        public Node(Book data)
        {
            Data = data;
            Next = null;
        }
    }
}
