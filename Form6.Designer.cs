namespace _20
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox7 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Showcard Gothic", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(-1, -2);
            label1.Name = "label1";
            label1.Size = new Size(584, 106);
            label1.TabIndex = 1;
            label1.Text = "Спортивный \r\nмарафон 2024";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(-1, 424);
            label2.Name = "label2";
            label2.Size = new Size(584, 26);
            label2.TabIndex = 5;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(29, 118);
            label3.Name = "label3";
            label3.Size = new Size(518, 71);
            label3.TabIndex = 6;
            label3.Text = "Пожалуйста,выберите бегуна, которого вы хотели бы спонсировать и сумму, которую вы хотели бы пожертвовать.Спасибо за вашу поддержку бегунов и их благотворительных учереждений.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 179);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 7;
            label4.Text = "Информация о Спонсоре";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(341, 183);
            label5.Name = "label5";
            label5.Size = new Size(170, 20);
            label5.TabIndex = 8;
            label5.Text = "Сумма пожертвования";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Вася", "Александр", "Олег", "Геннадий" });
            comboBox1.Location = new Point(118, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 28;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.SizeAll;
            textBox1.Location = new Point(118, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 27;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 263);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 26;
            label6.Text = "Карта:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 234);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 25;
            label7.Text = "Бегун:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 205);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 24;
            label8.Text = "Ваше имя:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 30;
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 292);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 31;
            label9.Text = "Номер карты:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 318);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 32;
            label10.Text = "Срок действия:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(118, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(44, 23);
            textBox4.TabIndex = 33;
            textBox4.Click += textBox4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 318);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(99, 23);
            textBox5.TabIndex = 34;
            textBox5.Click += textBox5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(118, 347);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(63, 23);
            textBox6.TabIndex = 35;
            textBox6.Click += textBox6_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(79, 350);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 36;
            label11.Text = "CVC:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(341, 213);
            label12.Name = "label12";
            label12.Size = new Size(181, 65);
            label12.TabIndex = 37;
            label12.Text = "label12";
            label12.Click += label12_Click;
            // 
            // button1
            // 
            button1.Location = new Point(333, 288);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 38;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(485, 288);
            button2.Name = "button2";
            button2.Size = new Size(37, 27);
            button2.TabIndex = 39;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(379, 292);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 40;
            textBox7.Click += textBox7_Click;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(350, 377);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 41;
            button3.Text = "Сохранить ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(436, 377);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 42;
            button4.Text = "Отмена";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Спонсорство";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private TextBox textBox7;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private Button button4;
    }
}