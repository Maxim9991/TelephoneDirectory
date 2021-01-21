using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TelephoneDirectory.Class;
using Bogus;
    

namespace TelephoneDirectory
{
    public partial class Form2 : Form
    {
            MyContext context = new MyContext();
            TelePhoneDirectory telePhoneDirectory = new TelePhoneDirectory();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telePhoneDirectory.Firstname = textBox1.Text;
            telePhoneDirectory.Lastname = textBox2.Text;
            telePhoneDirectory.Telephone = textBox3.Text;
            telePhoneDirectory.City = textBox4.Text;
            telePhoneDirectory.Gender = comboBox1.Text;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else
            {
                context.userDirectory.Add(telePhoneDirectory);
                context.SaveChanges();
                this.Close();
            } 
        }

        private void btnRandAdd_Click(object sender, EventArgs e)
        {
            var faker = new Faker("uk");

            ///////
            //////
            /////
            ////
            ///
            //

            textBox1.Text = faker.Name.FirstName();
            textBox2.Text = faker.Name.LastName();
            textBox3.Text = faker.Phone.PhoneNumber();
            textBox4.Text = faker.Address.City();

            Random random = new Random();
            int rnd = random.Next(1, 3);

            if (rnd == 1)
            {
                comboBox1.SelectedItem = "Чоловіча";
            }
            else if (rnd == 2)
            {
                comboBox1.SelectedItem = "Жіноча";
            }

        }
    }
}
