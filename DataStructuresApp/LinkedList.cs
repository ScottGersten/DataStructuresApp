using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp
{
    internal class LinkedList
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public Node head { get; set; }
        public Node tail { get; set; }

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            if (tail == null)
            {
                tail = newNode;
            }
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

        }

        public bool RemoveFirst(out int data)
        {
            if (head == null)
            {
                data = default(int);
                return false;
            }
            else
            {
                data = head.Data;
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
                return true;
            }
        }

        public bool RemoveLast(out int data)
        {
            if (head == null)
            {
                data = default(int);
                return false;
            }

            else if (head == tail)
            {
                data = head.Data;
                head = null;
                tail = null;
                return true;
            }

            else
            {
                Node newTail = head;
                while (newTail.Next != null)
                {
                    newTail = newTail.Next;
                }
                data = tail.Data;
                tail = newTail;
                tail.Next = null;
                return true;
            }
        }

        public bool RemoveValue(int value)
        {
            if (head == null)
            {
                return false;
            }

            else if (head.Data == value)
            {
                head = head.Next;
                if (head == tail)
                {
                    tail = null;
                }
                return true;
            }

            else
            {
                Node curr = head;
                while (curr.Next != null && curr.Next.Data != value)
                {
                    curr = curr.Next;
                }
                if (curr.Next == null)
                {
                    return false;
                }
                else if (curr.Next == tail)
                {
                    tail = curr;
                }
                curr.Next = curr.Next.Next;
                return true;

            }
        }

        public void Enqueue(int data) => AddLast(data);
        public bool Dequeue(out int data) => RemoveFirst(out data);
        public void Push(int data) => AddFirst(data);
        public bool Pop(out int data) => RemoveFirst(out data);

        public void PrintList()
        {
            Node curr = head;
            while (curr != null)
            {
                Console.Write(curr.Data);
                Console.Write(" -> ");
                curr = curr.Next;
            }
            Console.Write("-> END");
        }
    }
}
