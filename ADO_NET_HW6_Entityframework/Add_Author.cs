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
    public partial class Add_Author : Form
    {
        public Author author = new Author();
        public Add_Author()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author {FirstName = firstname_txbx.Text , LastName = lastname_txbx.Text};

            using (LibereryEntities db = new LibereryEntities())
            {
                Author check = db.Author.Where(x => x.FirstName == newAuthor.FirstName && x.LastName == newAuthor.LastName).FirstOrDefault();
                if (check == null)
                {
                    author = newAuthor;
                    MessageBox.Show("The author was added");
                    DialogResult = DialogResult.OK;
                    this.Close();
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
