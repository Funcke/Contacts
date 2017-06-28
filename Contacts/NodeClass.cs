using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class Node
    {
        //fields
        public Person Item;
        public Node Next;
        public Node Previous;
        //constructor
        public Node()
        {
            this.Item = new Person();
            this.Next = null;
            this.Previous = null;
        }

        public Node(Person val)
        {
            this.Item = new Person(val);
            this.Next = null;
            this.Previous = null;
        }

        public Node(string[] csv)
        {
            if (csv.Length == 4)
            {
                this.Item = new Person(csv);
                this.Next = null;
                this.Previous = null;
            }
            else
                throw new Exception(csv.Length + " Elements read");
            
        }
    }
}
