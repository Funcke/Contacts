using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public class Person
    {
        //private Fields
        private int _Age;
        private string _Name;
        private string _FamilyName;
        private string _Phone;

        //public properties
        public int Age
        {
            get
            {
                return this._Age;
            }
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
        }
        public string FamilyName
        {
            get
            {
                return this._FamilyName;
            }
        }

        public string Phone
        {
            get
            {
                return this._Phone;
            }
        }

        //Constructor
        public Person()
        {
            this._FamilyName = "";
            this._Name = "";
            this._Phone = "";
            this._Age = 0;
        }

        public Person(int age, string name, string famName, string phone)
        {
            this._Age = age;
            this._Name = name;
            this._FamilyName = famName;
            this._Phone = phone;
        }

        public Person(Person Pers):this(Pers.Age, Pers.Name, Pers.FamilyName, Pers.Phone)
        {
            ;
        }

        public Person(string[] csv)
        {
            this._Name = csv[0];
            this._FamilyName = csv[1];
            this._Phone = csv[2];
            this._Age = Convert.ToInt32(csv[3]);
        }
    }
}
