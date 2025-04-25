using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_pass_storage_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseHelper.InitializeDatabase();  // Инициализируем базу данных при запуске приложения
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();  // Открываем форму регистрации как модальное окно
        }

        private void Auth_button_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (User.Authenticate(username, password))
            {
                // Если пользователь авторизован, открываем основную форму
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';  // Показываем символы пароля
                button1.Image = Properties.Resources.open1;
            }
            else
            {
                textBox2.PasswordChar = '*';  // Скрываем символы пароля
                button1.Image = Properties.Resources.close1;
            }
        }
    }
}
