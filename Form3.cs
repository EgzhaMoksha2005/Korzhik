using _20.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form3 : Form
    {
        private DateTime dt = new DateTime(2024, 04, 05, 12, 00, 00);

        public Form3()
        {

            InitializeComponent();
            timer1.Interval = 120;
            timer1.Start();
            label2.Text = "Спортивный марафон 2024 \n Москва \n Пятница 5 апреля 2024";
            textBox1.Text = "Имя";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Фамилия";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Новый пароль";
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "Повторить";
            textBox4.ForeColor = Color.Gray;
            textBox1.Text = Settings.Default["name"].ToString();
            textBox2.Text = Settings.Default["sername"].ToString();
            dateTimePicker1.Text = Settings.Default["date"].ToString();
            comboBox1.Text = Settings.Default["sex"].ToString();
            comboBox2.Text = Settings.Default["country"].ToString();
            label3.Text = "Логин: " + Settings.Default["login"].ToString();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var d = dt - DateTime.Now;
            label2.Text = $"{d.Days} дней {d.Hours} часов {d.Minutes} минут {d.Seconds} секунд до старта мероприятия!";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == textBox4.Text)
            {
                Settings.Default["password"] = textBox3.Text;
            }
            Settings.Default["name"] = textBox1.Text;
            Settings.Default["sername"] = textBox2.Text;
            Settings.Default["sex"] = comboBox1.Text;
            Settings.Default["country"] = comboBox2.Text;
            Settings.Default["date"] = dateTimePicker1.Text;

            Settings.Default.Save();
            MessageBox.Show("Информация сохранена)))");

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox4.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
