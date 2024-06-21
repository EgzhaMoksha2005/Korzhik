using _20.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20
{
    public partial class Form2 : Form
    {
        private DateTime dt = new DateTime(2024, 04, 05, 12, 00, 00);
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 120;
            timer1.Start();
            label2.Text = "Спортивный марафон 2024 \n Москва \n Пятница 5 апреля 2024";
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            var d = dt - DateTime.Now;
            label2.Text = $"{d.Days} дней {d.Hours} часов {d.Minutes} минут {d.Seconds} секунд до старта мероприятия!";
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для получения доп.информации, пожалуйста, свяжитесь с координаторами. " + "\n Телефон: +7 (923) 783-31-83", "Контакты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Settings.Default["login"] = null;
            Settings.Default["password"] = null;
            Settings.Default.Save();
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
            this.Close();
        }
    }
}
