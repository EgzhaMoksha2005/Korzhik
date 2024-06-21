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
    public partial class Form6 : Form
    {
        private DateTime dt = new DateTime(2024, 12, 06, 12, 00, 00);
        int sum = 0;
        public Form6()
        {
            InitializeComponent();
            timer1.Interval = 120;
            timer1.Start();
            label2.Text = "Спортивный марафон 2024 \n Москва \n Пятница 6 декабря 2024";
            textBox1.Text = "Ваше имя";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Владелец карты";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "1234 1234 1234 1234";
            textBox3.ForeColor = Color.Gray;
            textBox4.Text = "01";
            textBox4.ForeColor = Color.Gray;
            textBox5.Text = "2024";
            textBox5.ForeColor = Color.Gray;
            textBox6.Text = "123";
            textBox6.ForeColor = Color.Gray;
            textBox7.Text = "0";
            textBox7.ForeColor = Color.Gray;

            label12.Text = "$" + sum.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var d = dt - DateTime.Now;
            label2.Text = $"{d.Days} дней {d.Hours} часов {d.Minutes} минут {d.Seconds} секунд до старта мероприятия!";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = null;
            textBox5.ForeColor = Color.Black;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = null;
            textBox6.ForeColor = Color.Black;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "0";
            textBox7.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum += 10;
            label12.Text = "$" + sum.ToString();
            textBox7.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum -= 10;
            label12.Text = "$" + sum.ToString();
            textBox7.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 0)
            {
                sum = Convert.ToInt32(textBox7.Text);
                label12.Text = "$" + sum.ToString();
            }
            else
            {
                sum = 0;
                label12.Text = "$" + sum.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
