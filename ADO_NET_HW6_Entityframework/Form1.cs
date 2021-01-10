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
            dataGridView1.DataSource = db.Author.ToList();
        }

        private void authors_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Author.ToList();
            source = authors_btn.Text;
        }

        private void books_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Book.ToList();
            source = books_btn.Text;
        }

        private void publishers_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Publisher.ToList();
            source = publishers_btn.Text;
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
                    Add_Author add_Author = new Add_Author();
                    add_Author.ShowDialog();
                    if(add_Author.DialogResult == DialogResult.OK)
                    {
                        db.Author.Add(add_Author.author);
                        db.SaveChanges();
                        Form1_Load(sender, null);
                    }
                    break;

                case "Books":
                    break;

                case "Publishers":
                    break;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            switch (source)
            {
                case "Authors":
                    break;

                case "Books":
                    break;

                case "Publishers":
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
