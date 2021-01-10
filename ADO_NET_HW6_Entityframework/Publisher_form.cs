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
    public partial class Publisher_form : Form
    {
        private Publisher publisher;

        public Publisher MyPublisher
        {
            get { return publisher; }
        }

        public Publisher_form()
        {
            InitializeComponent();
            publisher = new Publisher();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(name_txbx.Text) || String.IsNullOrEmpty(adress_txbx.Text))
            {
                MessageBox.Show("Fields can't be empty");
            }
            else
            {
                using(LibereryEntities db = new LibereryEntities())
                {
                    publisher.PublisherName = name_txbx.Text;
                    publisher.Address = adress_txbx.Text;
                    Publisher check = db.Publisher.Where(x => x.PublisherName == publisher.PublisherName).FirstOrDefault();
                    if(check == null)
                    {
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Publisher was added");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Publisher's already existed");
                        name_txbx.Text = "";
                        adress_txbx.Text = "";
                    }
               
                }
               
            }
        }
    }
}
