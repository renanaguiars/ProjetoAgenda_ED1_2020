using System;
using System.Collections.Generic;
using System.Text;

namespace Tela_01
{
    class Node
    {
        public Contact data;
        public Node prev;
        public Node next;

        public Node()
        {
            data = null;
            prev = null;
            next = null;
        }

        public Node(Contact contact)
        {
            data = contact;
            prev = null;
            next = null;
        }
    }
}
