using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET_HW6_Entityframework
{
    public partial class Author_form : Form
    {
        private Author author;

        public Author MyAuthor
        {
            get { return author; }
        }

        public Author_form()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            author = new Author {FirstName = firstname_txbx.Text , LastName = lastname_txbx.Text};

            using (LibereryEntities db = new LibereryEntities())
            {
                Author check = db.Author.Where(x => x.FirstName == author.FirstName && x.LastName == author.LastName).FirstOrDefault();
                if (check == null)
                {
                    if(!String.IsNullOrEmpty(firstname_txbx.Text) && !String.IsNullOrEmpty(lastname_txbx.Text))
                    {
                        MessageBox.Show("The author was added");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Firstname or lastname fields can't be empty!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("The author's already existed");
                    firstname_txbx.Text = "";
                    lastname_txbx.Text = "";
                }
            }        
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
