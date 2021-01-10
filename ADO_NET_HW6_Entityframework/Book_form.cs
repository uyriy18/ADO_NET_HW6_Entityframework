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
    public partial class Book_form : Form
    {
        private Book book;

        public Book MyBook
        {
            get { return book; }
        }

        public Book_form()
        {
            InitializeComponent();
            book = new Book();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(title_txbx.Text)   || String.IsNullOrEmpty(authorId_txbx.Text) || String.IsNullOrEmpty(publisherId_txbx.Text))
            {
                MessageBox.Show("Fields can't be empty");
                return;
            }
            else
            {
                using(LibereryEntities db = new LibereryEntities())
                {
                    try
                    {
                        int pages = Int32.Parse(pages_txbx.Text);
                        int price = Int32.Parse(price_txbx.Text);
                        int authorId = Int32.Parse(authorId_txbx.Text);
                        int publisherId = Int32.Parse(publisherId_txbx.Text);

                        if (pages < 0 || price < 0 || authorId < 0 || publisherId < 0)
                        {
                            MessageBox.Show("Pages, price or author Id must be more than 0");
                            return;
                        }
                        else
                        {
                            book.Title = title_txbx.Text;
                            book.Pages = pages;
                            book.Price = price;
                            book.IdAuthor = authorId;
                            book.IdPublisher = publisherId;
                            Book check =  db.Book.Where(x => x.Title == book.Title).FirstOrDefault();
                            if(check == null)
                            {
                                MessageBox.Show("Book was added");
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Book's already existed");
                                book = null;
                                pages_txbx.Text = "";
                                price_txbx.Text = "";
                                authorId_txbx.Text = "";
                                publisherId_txbx.Text = "";
                                title_txbx.Text = "";
                                return;
                            }
                          
                        }
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Incorect format!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pages_txbx.Text = "";
                        price_txbx.Text = "";
                        authorId_txbx.Text = "";
                        publisherId_txbx.Text = "";
                        return;
                    }
                }
                
              
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
