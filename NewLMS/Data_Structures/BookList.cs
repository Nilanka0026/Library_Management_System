using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace NewLMS.Data_Structures
{
    public class BookList
    {
        public Node? Head;
        public Node? Tail;
        public int count;
        


        public BookList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public void AddLast(Book book)
        {
            Node temp = new Node(book);
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
            if(Head == null) return;
            if(Head.Data.Id == id)
            {
                Head = Head.Next;
                return;
            }
            Node? current = Head;
            while (current.Next != null)
            {
                if(current.Next.Data.Id == id)
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
                Node current = Head;

                while (current.Next != null)
                {
                    if (current.Data.Id > current.Next.Data.Id)
                    {
                        Book temp = current.Data;
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
                Node current = Head;

                while (current.Next != null)
                {
                    if (current.Data.Id < current.Next.Data.Id)
                    {
                        Book temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;

                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }
        public void SelectionSortA()
        {
            if (Head == null || Head.Next == null)
                return;

            Node current = Head;

            while (current != null)
            {
                Node minNode = current;
                Node nextNode = current.Next;

                while (nextNode != null)
                {
                    if (nextNode.Data.Id < minNode.Data.Id)
                    {
                        minNode = nextNode;
                    }
                    nextNode = nextNode.Next;
                }

                
                if (minNode != current)
                {
                    Book temp = current.Data;
                    current.Data = minNode.Data;
                    minNode.Data = temp;
                }

                current = current.Next;
            }
        }
        public void SelectionSortD()
        {
            if (Head == null || Head.Next == null)
                return;

            Node current = Head;

            while (current != null)
            {
                Node minNode = current;
                Node nextNode = current.Next;

                while (nextNode != null)
                {
                    if (nextNode.Data.Id > minNode.Data.Id)
                    {
                        minNode = nextNode;
                    }
                    nextNode = nextNode.Next;
                }


                if (minNode != current)
                {
                    Book temp = current.Data;
                    current.Data = minNode.Data;
                    minNode.Data = temp;
                }

                current = current.Next;
            }
        }
        public void InsertionSortA()
        {
            if (Head == null || Head.Next == null)
                return; 

            Node sorted = null;
            Node current = Head;

            while (current != null)
            {
                Node next = current.Next;

                
                if (sorted == null || current.Data.Id < sorted.Data.Id)
                {
                    
                    current.Next = sorted;
                    sorted = current;
                }
                else
                {
                    
                    Node temp = sorted;
                    while (temp.Next != null && temp.Next.Data.Id < current.Data.Id)
                    {
                        temp = temp.Next;
                    }

                    
                    current.Next = temp.Next;
                    temp.Next = current;
                }

                current = next; 
            }

            Head = sorted;
        }
        public void InsertionSortD()
        {
            if (Head == null || Head.Next == null)
                return;

            Node sorted = null;
            Node current = Head;

            while (current != null)
            {
                Node next = current.Next;


                if (sorted == null || current.Data.Id > sorted.Data.Id)
                {

                    current.Next = sorted;
                    sorted = current;
                }
                else
                {

                    Node temp = sorted;
                    while (temp.Next != null && temp.Next.Data.Id > current.Data.Id)
                    {
                        temp = temp.Next;
                    }


                    current.Next = temp.Next;
                    temp.Next = current;
                }

                current = next;
            }

            Head = sorted;
        }
    }
}
