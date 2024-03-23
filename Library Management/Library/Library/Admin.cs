using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Checked)
                {
                    button1.Visible = true;
                    label5.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;

                    label13.Visible = false;
                    label14.Visible = false;
                    button2.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;

                    label15.Visible = false;
                    label16.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    button3.Visible = false;
                    label17.Visible = false;
                    textBox10.Visible = false;
                    button4.Visible = false;
                    comboBox1.Visible = false;
                    label18.Visible = false;

                    label20.Visible = false;
                    dateTimePicker1.Visible = false;
                    label22.Visible = false;
                    label21.Visible = false;
                    textBox12.Visible = false;
                    radioButton5.Visible = false;
                    radioButton6.Visible = false;
                    radioButton7.Visible = false;
                    label24.Visible = false;
                    comboBox2.Visible = false;


                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Visible = false;

                label5.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;

                label13.Visible = true;
                label14.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                button2.Visible = true;

                label15.Visible = false;
                label16.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button3.Visible = false;
                label17.Visible = false;
                textBox10.Visible = false;
                button4.Visible = false;
                comboBox1.Visible = false;
                label18.Visible = false;

                label20.Visible = true;
                dateTimePicker1.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                textBox12.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                label24.Visible = true;
                comboBox2.Visible = true;

                LibraryContext db = new LibraryContext();
                List<Libraryy> listLib = db.Librariees.ToList();
                comboBox2.DataSource = listLib;
                comboBox2.ValueMember = "ID";
                comboBox2.DisplayMember = "comboBox2";




            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button1.Visible = false;

                label5.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                button2.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label15.Visible = true;
                label16.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                button3.Visible = true;
                label17.Visible = false;
                textBox10.Visible = false;
                button4.Visible = false;
                comboBox1.Visible = false;
                label18.Visible = false;

                label20.Visible = false;
                dateTimePicker1.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                textBox12.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                label24.Visible = false;
                comboBox2.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                button1.Visible = false;

                label5.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                button2.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                button3.Visible = false;

                label17.Visible = true;
                textBox10.Visible = true;
                button4.Visible = true;

                comboBox1.Visible = true;
                label18.Visible = true;

                label20.Visible = false;
                dateTimePicker1.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                textBox12.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                label24.Visible = false;
                comboBox2.Visible = false;

                LibraryContext db = new LibraryContext();
                List<Libraryy> list = db.Librariees.ToList();
                comboBox1.DataSource = list;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "comboBox1";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Librariann l = new Librariann() { Name = textBox1.Text, Username = textBox2.Text, Password = Int32.Parse(textBox3.Text), Address = textBox4.Text, Position = textBox5.Text };
                AdminOperation AO = new AdminOperation();
                AO.CreateLibrarian(l);
            }

            catch (System.FormatException ex)
            {
                MessageBox.Show("The type of attribute is wrong, Try again");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Libraryy li = new Libraryy() { name = textBox8.Text, address = textBox9.Text };
            AdminOperation AO = new AdminOperation();
            AO.CreateLibrary(li);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Patronn p = new Patronn();

            p.name = textBox6.Text;
            p.address = textBox7.Text;

         
            AdminOperation AO = new AdminOperation();

            int x = AO.CreatePatron(p);
            Account a = new Account();

            // a.ID = Int32.Parse(textBox11.Text);
            a.History = textBox12.Text;
            a.Opened = dateTimePicker1.Value;
            a.LibraryID = Convert.ToInt32(comboBox2.Text);


            a.PatronID = x;
            if (radioButton5.Checked)
            {
                a.State = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                a.State = radioButton6.Text;

            }
            else if (radioButton7.Checked)
            {
                a.State = radioButton7.Text;

            }
            LibraryContext ctx = new LibraryContext();
            ctx.Accounts.Add(a);
            ctx.SaveChanges();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
                LibraryContext ctx = new LibraryContext();
                Catalog c1 = new Catalog() { Name = textBox10.Text };
                c1.LibraryID = Convert.ToInt32(comboBox1.Text);

                AdminOperation AO = new AdminOperation();
                AO.CreateCatalog(c1);
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
