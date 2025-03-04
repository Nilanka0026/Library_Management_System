using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLMS.Data_Structures
{
    public class MemberList
    {
        public mNode? Head;
        public mNode? Tail;
        public int count;


        public MemberList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public void AddLast(Member member)
        {
            mNode temp = new mNode(member);
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
            mNode? current = Head;
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
        public void sorta()
        {
            if (Head == null || Head.Next == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                mNode current = Head;

                while (current.Next != null)
                {
                    if (current.Data.Id > current.Next.Data.Id)
                    {
                        Member temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }
        public void sortd()
        {
            if (Head == null || Head.Next == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                mNode current = Head;

                while (current.Next != null)
                {
                    if (current.Data.Id < current.Next.Data.Id)
                    {
                        Member temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);

        }
    }
}
