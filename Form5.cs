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
    public partial class Form5 : Form
    {
        private DateTime dt = new DateTime(2024, 12, 06, 12, 00, 00);
        public Form5()
        {
            InitializeComponent();
            timer1.Interval = 120;
            timer1.Start();
            label2.Text = "Спортивный марафон 2024 \n Москва \n Пятница 6 декабря 2024";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var d = dt - DateTime.Now;
            label2.Text = $"{d.Days} дней {d.Hours} часов {d.Minutes} минут {d.Seconds} секунд до старта мероприятия!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
