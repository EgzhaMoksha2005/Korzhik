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
    public partial class Form4 : Form
    {
        int cheking = 0;
        int sum = 0;
        private DateTime dt = new DateTime(2024, 12, 06, 12, 00, 00);
        public Form4()
        {
            InitializeComponent();
            sum.ToString();
            label8.Text = "$" + sum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var d = dt - DateTime.Now;
            label2.Text = $"{d.Days} дней {d.Hours} часов {d.Minutes} минут {d.Seconds} секунд до старта мероприятия!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();

            frm2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cheking == 2 & comboBox1.SelectedItem != null & textBox1.TextLength != 0)
            {
                MessageBox.Show("Вы успешно зарегестрировались на марафон!");
            }
            else
            {
                MessageBox.Show("Ошибка регистрации! Заполните все поля!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                sum += 145;
                cheking += 1;
            }
            else
            {
                sum -= 145;
                cheking -= 1;
            }
            label8.Text = "$" + sum;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                sum += 75;
                cheking += 1;
            }
            else
            {
                sum -= 75;
                cheking -= 1;
            }
            label8.Text = "$" + sum;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                sum += 20;
                cheking += 1;
            }
            else
            {
                sum -= 20;
                cheking -= 1;
            }
            label8.Text = "$" + sum;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sum += 20;
                cheking += 1;
            }
            else
            {
                sum -= 20;
                cheking -= 1;
            }
            label8.Text = "$" + sum;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                sum += 45;
                cheking += 1;
            }
            else
            {
                sum -= 45;
                cheking -= 1;
            }
            label8.Text = "$" + sum;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

                cheking += 1;
            }
            else
            {
                cheking -= 1;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
