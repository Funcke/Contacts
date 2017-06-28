using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contacts
{
    public partial class ContactEdit : Form
    {
        private CustomLinkedList list;
        private int action;
        private Form1 source;
        private bool _exception;

        public CustomLinkedList List
        {
            get
            {
                return this.list;
            }

            set
            {
                this.list = value;
            }
        }

        public ContactEdit()
        {
            InitializeComponent();
            this._exception = false;
        }

        public ContactEdit(Form1 source, int action)
            : this()
        {
            this.action = action;
            this.source = source;

            if(this.action == 2)
            {
                this.InitInput();
            }
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Person Target = GetPersonData();

                if (Target != default(Person))
                {
                    switch (this.action)
                    {
                        case 0: this.source.List.Add(Target); break;
                        case 1: this.source.List.Insert(Target); break;
                        case 2: this.source.List.Update(Target); break;
                        default:; break;
                    }
                }

                this.source.UpdateListBox(source.List.Current.Item);
                this.source.List.Export();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                this._exception = true;
            }
            finally
            {
                if (this._exception == false)
                    this.Close();
            }
        }

        private void cmd_Discard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Changes have been discarded");
            this.source.Show();
            this.Close();
        }

        private Person GetPersonData()
        {
            string name, familyName, phone;
            int age;
            Person rc;
            
            try
            {
                name = Convert.ToString(txt_Name.Text);
                familyName = Convert.ToString(txt_FamilyName.Text);
                phone = Convert.ToString(txt_Phone.Text);

                if (name.Length < 2 || familyName.Length < 2 || phone.Length < 5 || phone.Length > 13)
                    throw new StringTooShortException();

                age = Convert.ToInt32(txt_Age.Text);
                if (age < 0 || age > 150)
                    throw new AgeOutOfRangeExceptrion();

                rc = new Person(age, name, familyName, phone);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                rc = default(Person);
                this._exception = true;
            }

            return rc;
        }

        private void InitInput()
        {
            this.txt_Name.Text = this.source.List.Current.Item.Name;
            this.txt_FamilyName.Text = this.source.List.Current.Item.FamilyName;
            this.txt_Phone.Text = this.source.List.Current.Item.Phone;
            this.txt_Age.Text = Convert.ToString(this.source.List.Current.Item.Age);
        }
    }
}
