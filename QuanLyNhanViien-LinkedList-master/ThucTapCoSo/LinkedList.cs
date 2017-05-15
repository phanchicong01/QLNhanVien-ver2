using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTapCoSo
{
    class LinkedList
    {
        private Node pHead;
        private Node pTail;
        /// <summary>
        /// Khoi tao danh sach lien ket
        /// </summary>
        public LinkedList()
        {
            PHead = new Node();
            PTail = new Node();
            PHead = PTail = null;
        }

        public Node PHead
        {
            get { return pHead; }
            set { pHead = value; }
        }

        public Node PTail
        {
            get { return pTail; }
            set { pTail = value; }
        }
    }
}
