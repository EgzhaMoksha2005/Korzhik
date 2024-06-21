using _20.Properties;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Settings.Default["login"].ToString();
            textBox2.Text = Settings.Default["password"].ToString();

            SetRandomizedCode();
            SetCaptcha();
            pictureBox1.Image = CaptchaImg;
        }
        private Bitmap _captcha = new Bitmap(221, 65);
        private String _code = String.Empty;
        private Random rand = new Random();

        public Bitmap CaptchaImg { get { return _captcha; } }
        public String Code { get { return _code; } }


        private void SetRandomizedCode()
        {
            _code = String.Empty;
            for (int i = 0; i < 5; i++)
            {
                char c = (char)(rand.Next('a', 'z' + 1));
                _code += c.ToString();
            }
        }

        private void SetCaptcha()
        {
            FontStyle style = FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline | FontStyle.Regular | FontStyle.Bold;
            Font font = new Font("Arial", 30f, style);

            Graphics GFX = Graphics.FromImage(_captcha);
            GFX.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GFX.FillRectangle(Brushes.LightBlue, 0, 0, _captcha.Width, _captcha.Height);

            for (int j = 0; j < 351; j += 15)
                for (int i = 0; i < 70; i += 15)
                {
                    Color color = Color.FromArgb(rand.Next());
                    SolidBrush brush = new SolidBrush(color);
                    GFX.FillRectangle(brush, j, i, 15, 15);
                }
            int b = 20;
            int c = -3;
            Char[] _arrCode = _code.ToArray();

            for (int i = 0; i < 5; i++)
            {
                Color color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                SolidBrush brush = new SolidBrush(color);

                GFX.DrawString(_arrCode[i].ToString(), font, brush, new Point(b, c));
                b += 30;

                if (rand.Next(0, 2) == 1) c = -3;
                else c += 3;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button1.BackColor = Color.Gray;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int count = 0;
        string msg = DateTime.Now.ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Settings.Default["login"] = textBox1.Text;
                Settings.Default["password"] = textBox2.Text;
                Settings.Default.Save();
            }
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                MessageBox.Show("Добро пожаловать!" + textBox1.Text + msg);
                count = 0;
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();

            }
            else
            {

                MessageBox.Show("Логин/пароль введен не верно! Повторите ввод");
                count++;
                textBox1.Clear();
                textBox2.Clear();
            }
            if (count == 3)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("3 раза был введен неверный логин/пароль, приложение заблокированно");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Settings.Default["login"] = textBox1.Text;
                Settings.Default["password"] = textBox2.Text;
                Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Code == textBox3.Text)
            {
                MessageBox.Show("Ответ верный!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button2.Enabled = false;
                button1.Enabled = true;
                button1.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Ответ неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                SetRandomizedCode();
                SetCaptcha();
                pictureBox1.Image = CaptchaImg;
            }

        }
    }
}