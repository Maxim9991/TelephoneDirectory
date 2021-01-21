using Bogus;
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
using TelephoneDirectory.Class;

namespace TelephoneDirectory
{
    public partial class Form1 : Form
    {
        private readonly MyContext _context;


        private int pageUser = 1;
        private int showUser = 10;
        private string authorName = "AuthorName: Maxim Radchenko";

        public Form1()
        {
            _context = new MyContext();
            InitializeComponent();
        }
        
        // Загальна кількість записів
        private void CountAll()
        {
            var list = _context.userDirectory;
            lblCountt.Text = "Всього записів: " + list.Count().ToString();
        }

        // Кількість записів на сторінці
        private void DiapozonPage()
        {
            int diapozone = (pageUser - 1) * 10 + 1;
            lblDiapozonPage.Text = $"Показ: {diapozone} - {diapozone + 10 - 1}";
        }

        // Виводить дані в datagridview
        public void ShowDatabase()
        {
            // Пошук по всьому
            string t = string.Empty;
            var query = _context.userDirectory.AsQueryable();

            t = txtSearch.Text;

            if (comboBox1.Text == "Іменні")
            {
                if (!string.IsNullOrEmpty(t))
                    query = query.Where(x => x.Firstname.Contains(t));
            }
            else if(comboBox1.Text == "Прізвищу")
            {
                if (!string.IsNullOrEmpty(t))
                    query = query.Where(x => x.Lastname.Contains(t));
            }
            else if (comboBox1.Text == "Телефону")
            {
                if (!string.IsNullOrEmpty(t))
                    query = query.Where(x => x.Telephone.Contains(t));
            }
            else if (comboBox1.Text == "Місту")
            {
                if (!string.IsNullOrEmpty(t))
                    query = query.Where(x => x.City.Contains(t));
            }
            else if (comboBox1.Text == "Статі")
            {
                if (!string.IsNullOrEmpty(t))
                    query = query.Where(x => x.Gender.Contains(t));
            }

            // виводить сторінки по 10 людей
            dataGridView1.Rows.Clear();
            foreach (var item in query.ToList().OrderBy(x => x.Id).Skip((pageUser - 1) * showUser).Take(showUser))
            {
                object[] row = {
                        $"{item.Id}",
                        $"{item.Firstname}",
                        $"{item.Lastname}",
                        $"{item.Telephone}",
                        $"{item.City}",
                        $"{item.Gender}"
                    };
                dataGridView1.Rows.Add(row);
            }
            CountAll();
            DiapozonPage();

            // Рахує загальну кількість сторінок
            var list = _context.userDirectory;
            int total = (list.Count() + showUser - 1) / showUser;
            // Виводить кількість сторінок
            lblPageNum.Text = $"{pageUser}/{total}";

            // Якщо поле пошуку пусте не буде видно скільки знайденно людей
            if (txtSearch.Text == "")
            {
                lblgSearch.Visible = false;
            }
            else
            {
                lblgSearch.Visible = true;
            }
            // Якщо не пусте покаже кількість знайдених людей
            lblgSearch.Text = "Знайдено: " + query.Count().ToString();
        }

        private void lblCount_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btnPage.Enabled = false;
            lblgSearch.Visible = false;
            // Виводимо базу в DataGridViev
            ShowDatabase();

            // Виводимо шукати по першому
            comboBox1.SelectedIndex = 0;

            lblAuthor.Text = authorName;
        }

        // Кнопка додати в базу
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        // Кнопка видалити
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            TelePhoneDirectory t = _context.userDirectory
                .SingleOrDefault(x => x.Id == id);

            //Якщо id існує
            if (t != null)
            {
                _context.userDirectory.Remove(t);
                _context.SaveChanges();
                MessageBox.Show($"Id {id} видаленно!");
                ShowDatabase();
            }
            // Якщо іD не існує
            else
            {
                MessageBox.Show("Id не існує");
            }

            // після видалення очистити строку
            textBox1.Text = "";
        }

        // Редагувати
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        // якщо в строка видалити пуста то кнопка не засвітиться
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }

        }

        // Кнопка перехода назад по сторінкам
        private void btnBack_Click(object sender, EventArgs e)
        {
            // якщо сторінка == 1 назад не перейде
            if (pageUser > 1)
            {
                pageUser -= 1;
                ShowDatabase();
            }
        }

        // Кнопка перехода вперед по сторінкам
        private void btnNext_Click(object sender, EventArgs e)
        {
            // загальний рахунок сторінок
            var list = _context.userDirectory;
            int total = (list.Count() + showUser - 1) / showUser;

            // якшо остання сторінка далі не перейде
            if (pageUser < total)
            {
                pageUser += 1;
                ShowDatabase();
            }
        }

        // Перейти на сторінку за вказаним номером
        private void btnPage_Click(object sender, EventArgs e)
        {
            // загальний рахунок сторінок
            var list = _context.userDirectory;
            int total = (list.Count() + showUser - 1) / showUser;

            // вводимо сюди номер сторінки на яку потребно перейти
            int page = int.Parse(txtBoxPage.Text);

            // якщо сторінка більше 1 і  не більша останьой сторінки
            if (page > 0 && page <= total)
            { 
                pageUser = page;
                ShowDatabase();
            }
            // якщо не вірно вказана сторінка
            else
            {
                lblNotFOuND.Text = $"Від 1 до {total}";
            }

            // зачистимо поле вводу після перехода сторінки
            txtBoxPage.Text = "";
            
        }

        // поле пошуку автоматичне
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        // поле переходу по сторінкам
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // якщо поле пусте кнопка не нажметься
            if (txtBoxPage.Text == "")
            {
                btnPage.Enabled = false;
            }
            else
            {
                btnPage.Enabled = true;
            }
        }

        // Картинка обновити базу
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        // Якщо навести мишкою на картинку вона збільшиться
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.Location = new Point(751, 375);
            toolTip1.SetToolTip(pictureBox1, "Оновити базу");
        }

        // Якщо забрати мишку з картинки вона зменшиться
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.Location = new Point(753, 377);
        }
    }
}
