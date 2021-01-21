using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TelephoneDirectory.Class;


namespace TelephoneDirectory
{
    public partial class Form3 : Form 
    {
        MyContext context = new MyContext();
        //TelePhoneDirectory TelePhoneDirectory = new TelePhoneDirectory();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRedaguvaty_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox55.Text);

                TelePhoneDirectory t = context.userDirectory
                    .SingleOrDefault(x => x.Id == id);

                if(t != null)
                {
                    t.Firstname = textBox1.Text;
                    t.Lastname = textBox2.Text;
                    t.Telephone = textBox3.Text;
                    t.City = textBox4.Text;
                    t.Gender = textBox6.Text;

                    if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "")
                    {
                        MessageBox.Show("Заповніть всі поля");
                    }
                    else
                    {
                        context.SaveChanges();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Id не існує");
                }
        }
    }
}
