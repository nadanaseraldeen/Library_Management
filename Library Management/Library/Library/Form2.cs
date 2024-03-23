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

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 250, 250, 250);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        LibraryContext ctx = new LibraryContext();
            string username = "Nada2002";
            float password = 2342002;
            if (radioButton1.Checked)
            {
                if (textBox1.Text == username && float.Parse(textBox2.Text) == password)
                {
                    this.Hide();
                    Admin a = new Admin();
                    a.Show();
                }
                else
                    MessageBox.Show("The username or password incorrect, Try again");
            }

            else if (radioButton2.Checked)
            {
                try
                {
                    var ue = ctx.Librarianns.Where(c => c.Username == textBox1.Text).First();
                    var pa = ctx.Librarianns.Where(c => c.Password == Int32.Parse(textBox2.Text)).First();
                    if (ue != null && pa != null)
                    {
                        this.Hide();
                        LibrarianForm l = new LibrarianForm();
                        l.Show();
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("The Username Or Password Incorrect, Try Again");
                }


            }





        }



        }
    }

