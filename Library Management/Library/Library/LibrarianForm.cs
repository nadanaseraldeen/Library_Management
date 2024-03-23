using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Library
{
  
    public partial class LibrarianForm : Form
    {
        public LibrarianForm()
        {
            InitializeComponent();
            LibraryContext db = new LibraryContext();
            List<Catalog> list = db.Catalogs.ToList();
            comboBox2.DataSource = list;
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "comboBox2";

            List<Book> listBook = db.Books.ToList();
            comboBox1.DataSource = listBook;
            comboBox1.ValueMember = "BookID";
            comboBox1.DisplayMember = "comboBox1";

            List<Book> listBook2 = db.Books.ToList();
            comboBox6.DataSource = listBook2;
            comboBox6.ValueMember = "BookID";
            comboBox6.DisplayMember = "comboBox6";


            List<Librariann> listLibr = db.Librarianns.ToList();
            comboBox3.DataSource = listLibr;
            comboBox3.ValueMember = "ID";
            comboBox3.DisplayMember = "comboBox3";

            List<Libraryy> listlibrary = db.Librariees.ToList();
            comboBox4.DataSource = listlibrary;
            comboBox4.ValueMember = "ID";
            comboBox4.DisplayMember = "comboBox4";


            List<Patronn> listPat = db.Patronns.ToList();
            comboBox5.DataSource = listPat;
            comboBox5.ValueMember = "ID";
            comboBox5.DisplayMember = "comboBox5";

            List<Libraryy> listlibrary2 = db.Librariees.ToList();
            comboBox8.DataSource = listlibrary2;
            comboBox8.ValueMember = "ID";
            comboBox8.DisplayMember = "comboBox8";


            List<Patronn> listPatron = db.Patronns.ToList();
            comboBox7.DataSource = listPatron;
            comboBox7.ValueMember = "ID";
            comboBox7.DisplayMember = "comboBox7";

            List<Authorr> listAuth = db.Authorrs.ToList();
            comboBox9.DataSource = listAuth;
            comboBox9.ValueMember = "Name";
            comboBox9.DisplayMember = "comboBox9";

            
        }
        BookOperation bo = new BookOperation();
        LibraryContext ctx = new LibraryContext();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var lang = ctx.Books.Where(s => s.Language == "French").Select(s1 => s1.Title).ToList();
            listBox3.DataSource = lang;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Authorr a = new Authorr();
            
                a.Name = textBox1.Text;
                a.Biography = textBox9.Text;

                ctx.Authorrs.Add(a);
                ctx.SaveChanges();

                BookItem b = new BookItem();
                b.ISBN = textBox2.Text;
                b.Title = textBox3.Text;
                b.Summary = textBox4.Text;
                b.Publisher = textBox5.Text;
                b.Language = textBox6.Text;
                b.barcode = textBox7.Text;
                b.tag = Int32.Parse(textBox8.Text);
                b.NumberOfPage = Int32.Parse(textBox10.Text);
                b.PublicationDate = dateTimePicker1.Text;
                b.isReferenceOnly = textBox10.Text;
                b.CatalogID = Convert.ToInt32(comboBox2.Text);
                b.LibrarianID = Convert.ToInt32(comboBox3.Text);
                //  b.LibraryID = comboBox4.SelectedIndex + 1;
                b.LibraryID = Convert.ToInt32(comboBox4.Text);
                b.AuthorrID = a.ID;
                bo.createBook(b);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("The type of attribute is wrong, Try again");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var bb = ctx.BookItems.Where(s => s.BookID == Convert.ToInt32(comboBox1.Text)).Single();

                bb.ISBN = textBox2.Text;
                bb.Title = textBox3.Text;
                bb.Summary = textBox4.Text;
                bb.Publisher = textBox5.Text;
                bb.Language = textBox6.Text;
                bb.barcode = textBox7.Text;
                bb.tag = Int32.Parse(textBox8.Text);
                bb.NumberOfPage = Int32.Parse(textBox10.Text);
                bb.PublicationDate = dateTimePicker1.Text;
                bb.isReferenceOnly = textBox10.Text;

                var aa = ctx.Authorrs.Where(s => s.ID == Convert.ToInt32(comboBox1.Text)).Single();

                aa.Name = textBox1.Text;

                aa.Biography = textBox9.Text;

                ctx.SaveChanges();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("The type of attribute is wrong, Try again");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var d = ctx.BookItems.Where(s => s.BookID == Convert.ToInt64(comboBox1.Text)).Single();
            var aa = ctx.Authorrs.Where(s => s.ID == Convert.ToInt32(comboBox1.Text)).Single();
            ctx.Authorrs.Remove(aa);

            ctx.BookItems.Remove(d);
            ctx.SaveChanges();


        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                var authorName = ctx.BookItems.Where(x => x.BookID == Convert.ToInt64(comboBox1.Text)).Select(c => c.authorr.Name).Single();
                listBox1.DataSource = (authorName.ToList());
      

        }

        private void button4_Click(object sender, EventArgs e)
        {


            var s = ctx.BookItems.Any(x => x.Title.Equals(textBox12.Text) || x.ISBN.Equals(textBox12.Text));
            if (s == true)
                MessageBox.Show("This book exists");


            else
                MessageBox.Show("This book does not exists");



        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var max = ctx.Books.OrderByDescending(x => x.NumberOfPage).Take(1).Select(s1 => s1.Title).ToList();
            listBox2.DataSource = max;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var names = ctx.Patronns.Select(c => c.name).ToList();
            listBox4.DataSource = names;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var namesFrozen = ctx.Patronns.Where(x => x.account.State == "Frozen").Select(c => c.name).ToList();
            listBox5.DataSource = namesFrozen;
        }

        private void Patron_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            var bb = ctx.BookItems.Where(s => s.BookID == Convert.ToInt64(comboBox6.Text)).Single();

            bb.AccountID = Convert.ToInt32(comboBox5.Text);
            ctx.SaveChanges();


        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            var bb = ctx.BookItems.Where(s => s.BookID == Convert.ToInt64(comboBox6.Text)).Single();

            bb.AccountID = null;
            ctx.SaveChanges();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var a = ctx.Accounts.Where(s => s.PatronID == Convert.ToInt64(comboBox7.Text)).Single();

            a.History = textBox13.Text;

            a.Opened = dateTimePicker2.Value;



            if (radioButton1.Checked)
            {
                a.State = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                a.State = radioButton2.Text;

            }
            else if (radioButton3.Checked)
            {
                a.State = radioButton3.Text;

            }


            ctx.SaveChanges();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            var booksName = ctx.Books.Where(s => s.authorr.Name == comboBox9.Text).Select(s => s.Title).ToList();
            listBox6.DataSource = booksName;
        }
    }
}
