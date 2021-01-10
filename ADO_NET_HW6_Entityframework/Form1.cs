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
    public partial class Form1 : Form
    {
       
        LibereryEntities db = new LibereryEntities();
        string source = "Authors";
        public Form1()
        {
            InitializeComponent();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            switch (source)
            {
                case "Authors":
                    Author_form add_Author = new Author_form();
                    add_Author.ShowDialog();
                    if(add_Author.DialogResult == DialogResult.OK)
                    {
                        db.Author.Add(add_Author.MyAuthor);
                        db.SaveChanges();
                    }
                    break;

                case "Books":
                    Book_form add_Book = new Book_form();
                    try
                    {
                        add_Book.ShowDialog();
                        if (add_Book.DialogResult == DialogResult.OK)
                        {
                            db.Book.Add(add_Book.MyBook);
                            db.SaveChanges();
                        }
                    }
                    catch  
                    { 
                        MessageBox.Show("Incorrect author or publisher id");
                        add_Book.ShowDialog();
                    }

                    break;

                case "Publishers":
                    Publisher_form add_Publisher = new Publisher_form();
                    add_Publisher.ShowDialog();
                    if(add_Publisher.DialogResult == DialogResult.OK)
                    {
                        db.Publisher.Add(add_Publisher.MyPublisher);
                        db.SaveChanges();
                    }
                    break;
            }
            Form1_Load(sender, null);
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {

            switch (source)
            {
                case "Authors":
                    int authorId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    var au = db.Author.Where(x => x.Id == authorId).FirstOrDefault();
                    DialogResult aResult = MessageBox.Show("Do you want to delete the author?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if(aResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"Author {au.FirstName} {au.LastName} was deleted");
                        db.Author.Remove(au);
                        db.SaveChanges();
                    }
                    else if(aResult == DialogResult.No || aResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    break;

                case "Books":
                    int bookId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    var book = db.Book.Where(x => x.Id == bookId).FirstOrDefault();
                    DialogResult bResult = MessageBox.Show("Do you want to delete the book?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if(bResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"Author {book.Title} was deleted");
                        db.Book.Remove(book);
                        db.SaveChanges();
                    }
                    else if(bResult == DialogResult.No || bResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    
                    break;

                case "Publishers":
                    int publisherId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    var publisher = db.Publisher.Where(x => x.Id == publisherId).FirstOrDefault();
                    DialogResult pResult = MessageBox.Show("Do you want to delete the publisher?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if(pResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"Author {publisher.PublisherName} was deleted");
                        db.Publisher.Remove(publisher);
                        db.SaveChanges();
                    }
                    else if(pResult == DialogResult.No || pResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    
                    break;
            }
            Form1_Load(sender, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkSource();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells[0].ReadOnly = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            source = Main_form.SelectedTab.Text;
            Main_form.SelectedTab.Controls.Add(dataGridView1);
            checkSource();
            
        }
        void checkSource()
        {
            switch (source)
            {
                case "Authors":
                    dataGridView1.DataSource = db.Author.ToList();
                    break;

                case "Books":
                    dataGridView1.DataSource = db.Book.ToList();
                    break;

                case "Publishers":
                    dataGridView1.DataSource = db.Publisher.ToList();
                    break;
            }
        }
    }
}
