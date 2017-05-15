using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    class Node
    {
        private Employee data;
        private Node pNext;

        public Node()
        {
            Data = new Employee();
            PNext = null;
        }

        public Node PNext
        {
            get { return pNext; }
            set { pNext = value; }
        }

        public Employee Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
