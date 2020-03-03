using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node _head;
        public LinkedList()
        {
            _head = null;
        }
        public void AddFirst(int data)
        {
            this._head = new Node(data, this._head);
        }
        public int RemoveFirst()
        {
            int data;
            data = this._head.Data;
            this._head = this._head.Link;
            return data;
        }
        public void AddLast(int data)
        {
            Node node;
            node = new Node(data, null);

            Node current = this._head;
            while (current.Link != null)
                current = current.Link;
            current.Link = node;
        }
       
    }
}
