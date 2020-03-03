using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        private int _data;
        private Node _link;
        public Node(int data, Node link)
        {
            _data = data;
            _link = link;
        }
        public int Data
        {
            get { return _data; }
        }
        public Node Link
        {
            get { return _link; }
            set { _link = value; }
        }
    }
}
