using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Card_Game
{
    class LinkedList
    {
        private Node _head;
        public LinkedList()
        {
            _head = null;
        }
        public void AddFirst(Card data)
        {
            this._head = new Node(data, this._head);
        }
        public Card RemoveFirst()
        {
            Card data;
            data = this._head.Data;
            this._head = this._head.Link;
            return data;
        }
        public void AddLast(Card data)
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
