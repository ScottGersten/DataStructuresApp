using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresApp
{
    internal class LinkedList
    {
        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
    }

        private Node head;
        private Node tail;

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
}
