using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Contacts
{
    public class CustomLinkedList
    {
        //Private fields for orientation
        private Node _First;
        private Node _Current;
        private Node _Last;
        private int _Count;

        //public properties
        public Node First
        {
            get
            {
                return this._First;
            }
        }

        public Node Last
        {
            get
            {
                return this._Last;
            }
        }

        public Node Current
        {
            get
            {
                return this._Current;
            }
            set
            {
                this._Current = value;
            }
        }

        public int Count
        {
            get
            {
                return this._Count;
            }
        }

        //public Constructor

        //standard constructor
        public CustomLinkedList()
        {
            this._First = null;
            this._Current = this._First;
            this._Last = this._First;
            this._Count = 0;
        }

        //one element constructor
        public CustomLinkedList(Node val)
        {
            this._First = val;
            this._First.Next = null;
            this._Current = this._First;
            this._Last = this._First;
        }

        //complete file constructor
        public CustomLinkedList(FileStream source)
        {
            StreamReader sr = new StreamReader(source);
            string line;
            string[] csv;

            line = sr.ReadLine();
            csv = line.Split(';');

            Node firstOfFile = new Node(csv);

            this._First = firstOfFile;
            this._Current = this._First;
            this._Last = this._First;
            this._Count++;
            
            while(sr.Peek() != -1)
            {
                line = sr.ReadLine();
                csv = line.Split(';');
                Person Item = new Person(csv);
                this.Add(Item);
            }

            sr.Close();
        }

        //public Methods

        //Moves to the next item if possible
        public Person MoveForward()
        {
            if (this._Current.Next != null)
                this._Current = this._Current.Next;
            return this._Current.Item;
        }

        //moves to the previous item if possible
        public Person MoveBackwards()
        {
            if (this._Current.Previous != null)
                this._Current = this._Current.Previous;
            return this._Current.Item;
        }

        //Adds the given value to the end of the list
        public Person Add(Person val)
        {
            Node Target = new Node(val);
            if (this._Count != 0)
            {
                this._Last.Next = Target;
                Target.Previous = this._Last;
                this._Last = this._Last.Next;
            }
            else
            {
                this._First = Target;
                this._Current = this._First;
                this._Last = this._First;
            }

            this._Count++;
            this._Current = this._Last;

            return this._Current.Item;
        }

        //inserts the given value before the current item
        public Person Insert(Person val)
        {
            if (this._Count != 0)
            {
                Node Target = new Node(val);
                if (this._Current != this._First)
                {
                    this._Current.Previous.Next = Target;
                    Target.Previous = this._Current.Previous;
                    Target.Next = this._Current;
                    this._Current.Previous = Target;
                    this._Current = this._Current.Previous;
                }
                else if (this._Current == this._First)
                {
                    this._Current.Previous = Target;
                    Target.Next = this._Current;
                    this._First = Target;
                    this._Current = this._First;
                }

                this._Count++;
            }
            else
            {
                this.Add(val);
            }   

            return this._Current.Item;
        }

        //updates the values in the current item
        public Person Update(Person val)
        {
            this._Current.Item = val;
            return this._Current.Item;
        }

        //Removes the current element
        public Person Remove()
        {
            if (this._Count != 0)
            {
                if (this._Current != this._First && this._Current != this._Last)
                {
                    this._Current.Previous.Next = this._Current.Next;
                    this._Current.Next.Previous = this._Current.Previous;
                    this._Current = this._Current.Next;
                    this._Count--;

                }
                else if (this._Current == this._First)
                {
                    if (this._First.Next != null)
                    {
                        this._First = this._First.Next;
                        this._First.Previous = null;
                        this._Current = this._First;
                        this._Count--;
                    }
                }
                else
                {
                    this._Last = this._Last.Previous;
                    this._Last.Next = null;
                    this._Current = this._Last;
                    this._Count--;
                }
            }
            else
            {
                this._Current.Item = default(Person);
            }
            
            return this._Current.Item;
        }

        //clears the complete list
        public void Clear()
        {
            this._First = null;
            this._Current = this._First;
            this._Last = this._First;
        }

        //Exports the list elements in a .csv file
        public void Export()
        {
            FileStream file = new FileStream("../../contacts.csv", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            Node helper = this.First;

            while (helper != null)
            {
                writer.WriteLine(helper.Item.Name + ";"
                                 + helper.Item.FamilyName + ";"
                                 + helper.Item.Phone + ";"
                                 + helper.Item.Age);
                helper = helper.Next;
            }

            writer.Close();
        }

        public void Search(string FamilyName, out Person[] rv)
        {
            if (FamilyName.Length < 2 || FamilyName.Length > 30)
            {
                rv = default(Person[]);
            }
            else
            {
                List<Person> help = new List<Person>();
                Node helper = this._First;
                while (helper != null)
                {
                    if (helper.Item.FamilyName == FamilyName)
                    {
                        help.Add(new Person(helper.Item));
                    }
                    helper = helper.Next;
                }

                rv = help.ToArray();
            }
        }
    }
}
