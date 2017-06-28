using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class SearchForm : Form
    {
        private CustomLinkedList _List;

        public Person[] OutputValues;

        public CustomLinkedList List
        {
            get
            {
                return this._List;
            }
            set
            {
                this._List = value;
            }
        }

        private SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(CustomLinkedList list)
            : this()
        {
            this._List = list;
        }

        private void ShowElements()
        {
            lb_Output.Items.Clear();
            if (OutputValues.Length != 0)
            {
                lb_Output.Items.Add(Convert.ToString(OutputValues.Length) + " Items found:");
                for (int i = 0; i < OutputValues.Length; i++)
                {
                    lb_Output.Items.Add(OutputValues[i].Name + " " + OutputValues[i].FamilyName);
                }
            }
            else
            {
                lb_Output.Items.Add("Nothing found");
            }
        }

        private void cmd_Search_Click(object sender, EventArgs e)
        {
            this._List.Search(txt_Search.Text, out OutputValues);
            if (OutputValues != default(Person[]))
            {
                ShowElements();
            }
            else
            {
                MessageBox.Show("An Error Occured while getting the search results");
            }
        }
    }
}
