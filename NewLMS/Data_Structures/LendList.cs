using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class LendList
    {
        public lNode? Head;
        public lNode? Tail;
        public int count;


        public LendList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public void AddLast(Lend item)
        {
            lNode temp = new lNode(item);
            if (Head == null)
            {
                Head = temp;
                Tail = temp;
                count++;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
                count++;
            }
        }
        public void remove(int id)
        {
            if (Head == null) return;
            if (Head.Data.Id == id)
            {
                Head = Head.Next;
                return;
            }
            lNode? current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data.Id == id)
                {
                    current.Next = current.Next.Next;
                    if (current.Next == null)
                    {
                        Tail = current;
                    }
                    return;
                }
                current = current.Next;
            }

        }
    }
}
