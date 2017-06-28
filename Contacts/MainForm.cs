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
    public partial class Form1 : Form
    {
        //Private Fields
        private CustomLinkedList list;

        //public properties
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

        //Constructors
        public Form1()
        {
            InitializeComponent();
            try
            {
                FileStream source = new FileStream("../../contacts.csv", FileMode.Open);
                list = new CustomLinkedList(source);
                UpdateListBox(list.Current.Item);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                lb_Show.Items.Clear();
                lb_Show.Items.Add("No Contacts yet, please initialize");
                list = new CustomLinkedList();
            }
            
        }

        private void cmd_Back_Click(object sender, EventArgs e)
        {
            if (this.list.Count != 0)
            {
                if (this.list.Current != this.list.First)
                {
                    this.list.MoveBackwards();
                }

                UpdateListBox(list.Current.Item);
            }
        }

        private void cmd_Forward_Click(object sender, EventArgs e)
        {
            if (this.list.Count != 0)
            {
                if (this.list.Current != this.list.Last)
                {
                    this.list.MoveForward();
                }


                UpdateListBox(this.list.Current.Item);
            }
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            ContactEdit FormEdit = new ContactEdit(this, Convert.ToInt32(Actions.Add));
            FormEdit.ShowDialog();
        }

        private void cmd_Insert_Click(object sender, EventArgs e)
        {
            ContactEdit FormEdit = new ContactEdit(this, Convert.ToInt32(Actions.Insert));
            FormEdit.ShowDialog();
        }

        private void cmd_Update_Click(object sender, EventArgs e)
        {
            if (this.list.Count != 0)
            {
                ContactEdit FormEdit = new ContactEdit(this, Convert.ToInt32(Actions.Update));
                FormEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("There Are no Contacts to be updated yet");
            }
        }

        private void cmd_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateListBox(this.list.Remove());
                this.list.Export();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Kein Element zu Entfernen");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
             
        }

        public void UpdateListBox(Person val)
        {
            if (this.list.Count != 0)
            {
                lb_Show.Items.Clear();
                lb_Show.Items.Add("Name: " + val.Name);
                lb_Show.Items.Add("FamilyName: " + val.FamilyName);
                lb_Show.Items.Add("Phone: " + val.Phone);
                lb_Show.Items.Add("Age: " + Convert.ToString(val.Age));
                lbl_Count.Text = Convert.ToString(this.list.Count) + " Contacts";
            }
        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(this.list);
            sf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
